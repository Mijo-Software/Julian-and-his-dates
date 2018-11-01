using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Julian_and_his_dates
{
  public partial class JulianandhisdatesForm : Form
  {
    double doubleOldJD = 0.999999999999999999999999, doubleNewJD;
    bool boolFirstRun = true;

    public JulianandhisdatesForm()
    {
      InitializeComponent();
    }

    private void updateDateInformations()
    {
      labelJulianDate.Text = JulianDatesClass.calcJulianDate().ToString();
      labelModifiedJulianDate.Text = JulianDatesClass.calcModifiedJulianDate().ToString();
      labelReducedJulianDate.Text = JulianDatesClass.calcReducedJulianDate().ToString();
      labelTruncatedJulianDate.Text = JulianDatesClass.calcTruncatedJulianDate().ToString();
      labelDublinJulianDate.Text = JulianDatesClass.calcDublinJulianDate().ToString();
      labelCnesJulianDate.Text = JulianDatesClass.calcCnesJulianDate().ToString();
      labelCcsdsJulianDate.Text = JulianDatesClass.calcCcsdsJulianDate().ToString();
      labelLopJulianDate.Text = JulianDatesClass.calcLopJulianDate().ToString();
      labelMillenniumJulianDate.Text = JulianDatesClass.calcMilleniumJulianDate().ToString();
    }

    private void JulianandhisdatesForm_Load(object sender, EventArgs e)
    {
      checkBoxAutomaticRefresh.Checked = true;
      updateDateInformations();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      updateDateInformations();
      doubleNewJD = JulianDatesClass.calcJulianDate();
      doubleNewJD = doubleNewJD - Math.Truncate(doubleNewJD);
      //MessageBox.Show("Old: " + doubleOldJD + " New:" + doubleNewJD);
      if (doubleNewJD < doubleOldJD)
      {
        doubleOldJD = doubleNewJD;
        if (boolFirstRun == true) boolFirstRun = false; else {
          SoundPlayer sound = new SoundPlayer(Properties.Resources.bleep);
          sound.Play();
          notifyIcon.BalloonTipText = JulianDatesClass.calcJulianDate().ToString();
          notifyIcon.BalloonTipTitle = "Julian Date switched to next number.";
          notifyIcon.ShowBalloonTip(500);
        }
      }
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
      updateDateInformations();
    }

    private void checkBoxAutomaticRefresh_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxAutomaticRefresh.Checked)
      {
        buttonRefresh.Enabled = false;
        timer.Enabled = true;
      }
      else
      {
        buttonRefresh.Enabled = true;
        timer.Enabled = false;
      }
    }

    private void buttonInfo_Click(object sender, EventArgs e)
    {
      bool boolMainWindowWasOnTop = false;
      if (this.TopMost == true) { this.TopMost = false; boolMainWindowWasOnTop = true; }
      AboutBoxForm about = new AboutBoxForm();
      if (checkBoxDarkLightMode.Checked == true)
      {
        about.BackColor = Color.FromArgb(29, 32, 41);
        about.ForeColor = Color.WhiteSmoke;
      }
      about.ShowDialog();
      if (boolMainWindowWasOnTop == true) this.TopMost = true;
    }

    private void buttonMinimizeToTray_Click(object sender, EventArgs e)
    {
      this.Hide();
      notifyIcon.Visible = true;
      notifyIcon.BalloonTipText = "Minimized";
      notifyIcon.BalloonTipTitle = "Application is running in background";
      notifyIcon.ShowBalloonTip(500);
    }

    private void labelJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Julian Date is based on the Julian Period proposed by Joseph Scaliger, a classical scholar, in 1583, at the time of the Gregorian calendar reform. A few centuries later in his book 'Outlines of Astronomy', first published in 1849, the astronomer John Herschel added the counting of days elapsed from the beginning of the Julian Period. Astronomers adopted Herschel's 'days of the Julian period' in the late nineteenth century, but used the meridian of Greenwich instead of Alexandria, after the former was adopted as the Prime Meridian after the International Meridian Conference in Washington in 1884. This has now become the standard system of Julian days numbers. The French mathematician and astronomer Pierre-Simon Laplace first expressed the time of day as a decimal fraction added to calendar dates in his book, Traité de Mécanique Céleste, in 1799. Other astronomers added fractions of the day to the Julian day number to create Julian Dates, which are typically used by astronomers to date astronomical observations, thus eliminating the complications resulting from using standard calendar periods like eras, years, or months. They were first introduced into variable star work by Edward Charles Pickering, of the Harvard College Observatory, in 1890.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelModifiedJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Modified Julian Date (MJD) was introduced by the Smithsonian Astrophysical Observatory in 1957 to record the orbit of Sputnik via an IBM 704 (36-bit machine) and using only 18 bits until August 7, 2576. MJD is the epoch of VAX/VMS and its successor OpenVMS, using 63-bit date/time, which allows times to be stored up to July 31, 31086, 02:48:05.47.[15] The MJD has a starting point of midnight on November 17, 1858 and is computed by MJD = JD - 2400000.5", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelReducedJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Reduced Julian Date (RJD) is similar to the MJD. The starting point was on 12h Nov 16, 1858 and is computed byRJD = JD − 2451544.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelTruncatedJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Truncated Julian Day (TJD) was introduced by NASA/Goddard in 1979 as part of a parallel grouped binary time code (PB-5) 'designed specifically, although not exclusively, for spacecraft applications.' TJD was a 4-digit day count from MJD 40000, which was May 24, 1968, represented as a 14-bit binary number. Since this code was limited to four digits, TJD recycled to zero on MJD 50000, or October 10, 1995, 'which gives a long ambiguity period of 27.4 years'. (NASA codes PB-1—PB-4 used a 3-digit day-of-year count.) Only whole days are represented. Time of day is expressed by a count of seconds of a day, plus optional milliseconds, microseconds and nanoseconds in separate fields. Later PB-5J was introduced which increased the TJD field to 16 bits, allowing values up to 65535, which will occur in the year 2147. There are five digits recorded after TJD 9999.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelDublinJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Dublin Julian Date (DJD) is the number of days that has elapsed since the epoch of the solar and lunar ephemerides used from 1900 through 1983, Newcomb's Tables of the Sun and Ernest W. Brown's Tables of the Motion of the Moon (1919). This epoch was noon UT on January 0, 1900, which is the same as noon UT on December 31, 1899. The DJD was defined by the International Astronomical Union at their meeting in Dublin, Ireland, in 1955.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelCnesJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The CNES Julian Date (CNES JD) was introduced by the Centre national d'études spatiales (CNES) (English: National Centre for Space Studies). This is the format used in CNES products like MSLA data files. The starting point of CNES JD was on 0h Jan 1, 1950 and is computed by CCNES JD = JD − 2433282.5.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelCcsdsJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The CCSDS Julian Date (CCSDS JD) was introduced by the Consultative Committee for Space Data Systems (CCSDS). This is the format used in TOPEX/POSEIDON altimetry. The starting point of CCSDS JD was on 0h Jan 1, 1958 and is computed by CCSDS JD = JD − 2436204.5.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelLopJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The LOP Julian Date (LOP JD) was introduced by the Laboratoire d'Oceanographie Physique (LOP) in Paris, France. The starting point of LOP JD was on 0h Jan 1, 1992 and is computed by LOP JD = JD − 2448622.5.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelMillenniumJulianDateText_Click(object sender, EventArgs e)
    {
      MessageBox.Show("The Millennium Julian Date (Millennium JD) is my own created modified Julian Date. The starting point was the Third Millennium on 0h Jan 1, 2000 and is computed by Millennium JD = JD − 2451544.5.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelModifiedJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelModifiedJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelReducedJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelReducedJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelTruncatedJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelTruncatedJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelDublinJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelDublinJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelCnesJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelCnesJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelCcsdsJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelCcsdsJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelLopJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelLopJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void labelMillenniumJulianDate_DoubleClick(object sender, EventArgs e)
    {
      Clipboard.SetText(labelMillenniumJulianDate.Text);
      MessageBox.Show("Copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.Show();
      notifyIcon.BalloonTipText = "Maximized";
      notifyIcon.BalloonTipTitle = "Application is running in foreground";
      notifyIcon.ShowBalloonTip(500);
      notifyIcon.Visible = false;
    }

    private void checkBoxStayOnTop_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxStayOnTop.Checked == true)
      {
        checkBoxStayOnTop.Text = "Not on &top";
        this.TopMost = true;
      } else {
        checkBoxStayOnTop.Text = "Always on &top";
        this.TopMost = false;
      }
    }

    private void checkBoxDarkLightMode_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxDarkLightMode.Checked == true)
      {
        this.BackColor = Color.FromArgb(29, 32, 41);
        labelJulianDateText.ForeColor = Color.WhiteSmoke;
        labelModifiedJulianDateText.ForeColor = Color.WhiteSmoke;
        labelReducedJulianDateText.ForeColor = Color.WhiteSmoke;
        labelTruncatedJulianDateText.ForeColor = Color.WhiteSmoke;
        labelDublinJulianDateText.ForeColor = Color.WhiteSmoke;
        labelCnesJulianDateText.ForeColor = Color.WhiteSmoke;
        labelCcsdsJulianDateText.ForeColor = Color.WhiteSmoke;
        labelLopJulianDateText.ForeColor = Color.WhiteSmoke;
        labelMillenniumJulianDateText.ForeColor = Color.WhiteSmoke;
        labelJulianDate.ForeColor = Color.WhiteSmoke;
        labelModifiedJulianDate.ForeColor = Color.WhiteSmoke;
        labelReducedJulianDate.ForeColor = Color.WhiteSmoke;
        labelTruncatedJulianDate.ForeColor = Color.WhiteSmoke;
        labelDublinJulianDate.ForeColor = Color.WhiteSmoke;
        labelCnesJulianDate.ForeColor = Color.WhiteSmoke;
        labelCcsdsJulianDate.ForeColor = Color.WhiteSmoke;
        labelLopJulianDate.ForeColor = Color.WhiteSmoke;
        labelMillenniumJulianDate.ForeColor = Color.WhiteSmoke;
        //this.ForeColor = Color.WhiteSmoke;
      } else {
        this.BackColor = SystemColors.Control;
        labelJulianDateText.ForeColor = SystemColors.ControlText;
        labelModifiedJulianDateText.ForeColor = SystemColors.ControlText;
        labelReducedJulianDateText.ForeColor = SystemColors.ControlText;
        labelTruncatedJulianDateText.ForeColor = SystemColors.ControlText;
        labelDublinJulianDateText.ForeColor = SystemColors.ControlText;
        labelCnesJulianDateText.ForeColor = SystemColors.ControlText;
        labelCcsdsJulianDateText.ForeColor = SystemColors.ControlText;
        labelLopJulianDateText.ForeColor = SystemColors.ControlText;
        labelMillenniumJulianDateText.ForeColor = SystemColors.ControlText;
        labelJulianDate.ForeColor = SystemColors.ControlText;
        labelModifiedJulianDate.ForeColor = SystemColors.ControlText;
        labelReducedJulianDate.ForeColor = SystemColors.ControlText;
        labelTruncatedJulianDate.ForeColor = SystemColors.ControlText;
        labelDublinJulianDate.ForeColor = SystemColors.ControlText;
        labelCnesJulianDate.ForeColor = SystemColors.ControlText;
        labelCcsdsJulianDate.ForeColor = SystemColors.ControlText;
        labelLopJulianDate.ForeColor = SystemColors.ControlText;
        labelMillenniumJulianDate.ForeColor = SystemColors.ControlText;
        //this.ForeColor = SystemColors.ControlText;
      }
    }
  }
}
