/*1/10/14
 * Tera Staten
 * UI for WindowsService2
 * Allows user to Start, Stop, and Pause the service window. Also gives 
 * errors when caught and prints the error to a textbox. Shows the status
 * of the service in a textbox.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using System.Collections;


namespace SampleServiceUI2
{
    public partial class ServiceControl : Form
    {
        WindowsService2.SampleService add = new WindowsService2.SampleService();//Initialize a SampleService to do addition
        ServiceController example = new ServiceController("SampleService", "USL-5T43FS1");//Add controller to service name and computer name
        TimeSpan timeout = TimeSpan.FromMilliseconds(30); //Used for Pause
        public ServiceControl()
        {
            InitializeComponent();
        }

        private void startService_Click(object sender, EventArgs e)
        {
            clearErrorMessage();
            try
            {
                example.Start(); //Starts the service
                startService.Hide(); //Hiding the Start Service button
                stopService.Show(); //Showing the Stop Service button 
                pauseService.Show(); //Showing the Pause Service button
                continueService.Show(); //Showing the Continue Service button
                //pauseService.Enabled = false;   ENABLE AND DISABLE BUTTONS LIKE THIS
            }
            catch (Exception ex)
            {
                errorCaught(ex.Message);
                Debug.WriteLine("Exception Message: " + ex.Message);
            }
            statusChanged("Started");
        }//End startService_Click

        private void pauseService_Click(object sender, EventArgs e)
        {
            clearErrorMessage();
            try
            {
                example.Pause(); //Pauses the service
                example.WaitForStatus(ServiceControllerStatus.Paused, timeout);
                statusChanged("Paused");
                startService.Hide(); //Hiding the Start Service button
            }
            catch (Exception ex)
            {
                errorCaught(ex.Message);
                Debug.WriteLine("Exception Message: " + ex.Message);
            }
        }//End pauseService_Click


        private void continueService_Click(object sender, EventArgs e)
        {
            clearErrorMessage();
            try
            {
                example.Continue(); //Continues the service
                example.WaitForStatus(ServiceControllerStatus.Running, timeout);
                statusChanged("Continued");
            }
            catch (Exception ex)
            {
                errorCaught(ex.Message);
                Debug.WriteLine("Exception Message: " + ex.Message);
            }
        }//End continueService_Click

        private void stopService_Click(object sender, EventArgs e)
        {
            clearErrorMessage();
            try
            {
                example.Stop(); //Stops the service
                startService.Show(); //Showing the Start Service button
                stopService.Hide(); //Hiding the Stop Service button
                pauseService.Hide(); //Hiding the Pause Service button
                continueService.Hide(); //Hiding the Continue Service button
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Message: " + ex.Message);
                errorCaught(ex.Message);
            }
            statusChanged("Stopped");
        }//End stopService_Click

        private void label1_Click(object sender, EventArgs e)
        {//Pointless but would not let me delete
        }//End label1_Click

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Pointless but would not let me delete
        }//End textBox1_TextChanged

        private void clearErrorMessage() //Used to clear the textbox so we can view other errors that may pop up later
        {
            errorMsg.Text = "";
        }//End clearErrorMessage

        private void statusChanged(string msg) //Function for changing the text of the read-only textBox
        {
            currentStatus.Text = msg;
        }//End statusChanged

        private void errorCaught(string msg) //For error message text
        {
            errorMsg.Text = msg;
        }//End errorCaught
        public List<Hashtable> GetEventEntryByEvent(ref string logName, ref string machineName, ref long instanceId)
        {
            try
            {
                //Create our list
                List<Hashtable> events = new List<Hashtable>();

                //Connect to the EventLog of the specified machine
                EventLog log = new EventLog(logName, machineName);

                //Now we want to loop through each entry
                foreach (EventLogEntry entry in log.Entries)
                {
                    //If we run accross one with the right entry id create a new Hashtable
                    //then add the Message, InstanceId, Source, and TimeWritten values from that entry
                    if (entry.InstanceId == instanceId)
                    {
                        Hashtable entryInfo = new Hashtable();

                        entryInfo.Add("Message", entry.Message);
                        entryInfo.Add("InstanceId", entry.InstanceId);
                        entryInfo.Add("Source", entry.Source);
                        entryInfo.Add("TimeWritten", entry.TimeWritten);

                        //Add this new hashtable to our list
                        events.Add(entryInfo);

                        entryInfo = null;

                    }
                }

                //Return the results
                return events;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return null;
            }
        } //End GetEventEntryByEvent
        public bool AddNewEntry(ref string source, ref string logName, ref string message)
        {
            try
            {
                //First we need to make sure that this source doesn't exist yet
                if (!EventLog.SourceExists(source))
                {
                    //Create our source by providing the source and the name of the 
                    //new log name
                    EventLog.CreateEventSource(source, logName);

                    //Due to latency we want to wait a bit for the source and
                    //log to be created. So we will sleep for 3 seconds
                    System.Threading.Thread.Sleep(3000);
                }

                //Now we need a new instance of the EventLog
                EventLog log = new EventLog();
                //Set the  source we're writing to
                log.Source = source;

                //Now write an entry
                log.WriteEntry(message, EventLogEntryType.Information, 99);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        } //End AddNewEntry

        public bool WriteNewEntry(ref string source, ref string logName, ref string machineName, ref string message)
        {
            try
            {
                //Create a new instance of the EventLog class
                EventLog log = new EventLog(logName, machineName, source);

                //Make sure the source exists and the log name exists
                //if either is found a new exception is thrown and the function is exited

                if (EventLog.SourceExists(source))
                {
                    //Make sure the log exists
                    if (EventLog.Exists(logName))
                    {
                        //Write the new entry
                        log.WriteEntry(message, EventLogEntryType.Information);

                    }
                    else
                    {
                        throw new Exception("Log name specified does not exist!");
                    }
                }
                else
                {
                    throw new Exception("The source name provided does not exist!");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }//EndWriteNewEntry
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double result = 0;
            double firstNum = convertToDouble(leftNum);
            double secondNum = convertToDouble(rightNum);
            Object selectedItem = opSelect.SelectedItem;
            string op = selectedItem.ToString();
            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }
            operationResult.Text = result.ToString();
        }

        private double convertToDouble(TextBox a)
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(a.Text);
            }
            catch (FormatException ex)
            {
                errorCaught(ex.Message);
            }
            return num;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
    }//end ServiceControl class
}//end SampleServiceUI namespace
