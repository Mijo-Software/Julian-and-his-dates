using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Julian_and_his_dates
{
  public partial class JulianandhisdatesForm : Form
  {
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
      labelMilleniumJulianDate.Text = JulianDatesClass.calcMilleniumJulianDate().ToString();
    }

    private void JulianandhisdatesForm_Load(object sender, EventArgs e)
    {
      checkBoxAutomaticRefresh.Checked = true;
      updateDateInformations();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      updateDateInformations();
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
      AboutBoxForm about = new AboutBoxForm();
      about.ShowDialog();
    }
  }
}
