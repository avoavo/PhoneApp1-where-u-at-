using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Scheduler;

namespace OnTimeAlarm
{
    public partial class Page1 : PhoneApplicationPage
    {
        private void ApplicationBarSaveButton_Click(object sender, EventArgs e)
        {
            // The code in the following steps goes here.

            // Generate a unique name for the new notification. You can choose a
            // name that is meaningful for your app, or just use a GUID.
            String name = System.Guid.NewGuid().ToString();

            // Get the begin time for the notification by combining the DatePicker
            // value and the TimePicker value.
            DateTime date = (DateTime)expirationDatePicker.Value;
            DateTime time = (DateTime)expirationTimePicker.Value;
            DateTime expirationTime = date + time.TimeOfDay;

            // Make sure that the begin time has not already passed.
            if (expirationTime < DateTime.Now)
            {
                MessageBox.Show("the desired date must be in the future.");
                return;
            }

            // Get the expiration time for the notification.
   //         date = (DateTime)expirationDatePicker.Value;
    //        time = (DateTime)expirationTimePicker.Value;
//            DateTime beginTime = date + time.TimeOfDay;

            // Make sure that the expiration time is after the begin time.

            double buffer = 0;

            if (txtBuffer.Text == "")
            {
                buffer = 0;
            }
            else
            {
                buffer = Convert.ToDouble(txtBuffer.Text);
            }

/*
            if (expirationTime.AddMinutes(-buffer) < DateTime.Now)
            {
                MessageBox.Show("Not enough time span.");
                return;
            } */

            // Determine which recurrence radio button is checked.
            RecurrenceInterval recurrence = RecurrenceInterval.None;
            if (dailyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Daily;
            }
            else if (weeklyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Weekly;
            }
            else if (monthlyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Monthly;
            }
            else if (endOfMonthRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.EndOfMonth;
            }
            else if (yearlyRadioButton.IsChecked == true)
            {
                recurrence = RecurrenceInterval.Yearly;
            }

            // Create a URI for the page that will be launched if the user
            // taps on the reminder. Use query string parameters to pass 
            // content to the page that is launched.
   /*         string param1Value = param1TextBox.Text;
            string param2Value = param2TextBox.Text;
            string queryString = "";
            if (param1Value != "" && param2Value != "")
            {
                queryString = "?param1=" + param1Value + "&param2=" + param2Value;
            }
            else if (param1Value != "" || param2Value != "")
            {
                queryString = (param1Value != null) ? "?param1=" + param1Value : "?param2=" + param2Value;
            }
            Uri navigationUri = new Uri("/ShowParams.xaml" + queryString, UriKind.Relative); */


            //See if reminderRadioButton is checked
      /*      if ((bool)reminderRadioButton.IsChecked)
            {
                Reminder reminder = new Reminder(name);
                reminder.Title = titleTextBox.Text;
                reminder.Content = contentTextBox.Text;
                reminder.BeginTime = beginTime;
                reminder.ExpirationTime = expirationTime;
                reminder.RecurrenceType = recurrence;
                reminder.NavigationUri = navigationUri;

                // Register the reminder with the system.
                ScheduledActionService.Add(reminder);
            } */

            //if reminderRadioButton is not checked, then it's an alarm
            TimeSpan timeDiff = expirationTime.AddMinutes(buffer).Subtract(DateTime.Now);

            if (timeDiff.Milliseconds<=0)
            {
                MessageBox.Show("Not enough time span.");
                return;
            }
            else
            {
                Alarm alarm = new Alarm(name);
//                alarm.Content = contentTextBox.Text;
                alarm.Sound = new Uri("/Ringtones/la_cucaracha.mp3", UriKind.Relative);
                alarm.ExpirationTime = expirationTime; //THIS IS ACTUALLY THE DESIRED ARRIVAL TIME
                double traveltime = 0;                              
                double need = traveltime + buffer;
                alarm.BeginTime = expirationTime.AddMinutes(-need); //THIS IS ACTUALLY THE WAKE UP TIME

    //            alarm.Title = titleTextBox.Text;
                alarm.Content = titleTextBox.Text + " " + destinationTextBox.Text;                 
 //               alarm.ExpirationTime = expirationTime;
                alarm.RecurrenceType = recurrence;

                ScheduledActionService.Add(alarm);
            }

            // Navigate back to the main reminder list page.
            NavigationService.GoBack();
        }

        public Page1()
        {
            InitializeComponent();
        }


    }
}