﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SGMOSOL.SCREENS;

namespace SGMOSOL.Custom_User_Contols
{
    public class SessionManager
    {
       
        int SessionTimeoutMilliseconds;
        private DateTime lastActivityTime;
        private Timer sessionTimer;

        public SessionManager()
        {
            SessionTimeoutMilliseconds = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Timer"]);
            // Initialize last activity time
            lastActivityTime = DateTime.Now;

            // Initialize and configure the session timer
            sessionTimer = new Timer();
            sessionTimer.Interval = 30000; // Check every second
            sessionTimer.Tick += SessionTimer_Tick;
        }

        public void StartTimer()
        {
            sessionTimer.Start();
        }

        public void ResetSession()
        {
            lastActivityTime = DateTime.Now;
        }

        private void SessionTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - lastActivityTime;
            if (elapsedTime.TotalMilliseconds >= SessionTimeoutMilliseconds)
            {
                // Stop the timer to prevent further ticks
                sessionTimer.Stop();

                // Session timeout
                MessageBox.Show("Session has timed out. You will be redirected to the login page.");
              

               // Application.Exit();
               // System.Diagnostics.Process.Start(Application.ExecutablePath);

                // Close the current form
                Form.ActiveForm.Close();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            else
            {
                // Update last activity time if session is still active
                lastActivityTime = DateTime.Now;
            }
        }
    }
}
