/*
 * Created by SharpDevelop.
 * User: Markus
 * Date: 19.07.2020
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace STM32_FFT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		SerialPort uart = null;
		byte[] ringbuffer = new byte[11];
		int ringbuffer_w_ptr = 0;
		int[] freqarray = new int [10];
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach(string port in ports)
            {
            	comboBox1.Items.Add(port);
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
	
		void Button1Click(object sender, EventArgs e)
		{
			uart = new SerialPort(comboBox1.SelectedItem.ToString(),	115200, Parity.None,8,StopBits.One);
			uart.ReadTimeout = 2000;
            uart.Open();
            uart.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
		}
		
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = uart.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            uart.Read(byteBuffer, 0, intBuffer);
            
            for (int i=0; i<byteBuffer.Length;i++) {
            	ringbuffer[ringbuffer_w_ptr] = byteBuffer[i];
            	ringbuffer_w_ptr++;
            	if (ringbuffer_w_ptr==11) ringbuffer_w_ptr=0;
            }
            
            int indexstart = 0;
            
            for (int i=0; i<11; i++) {
            	if (ringbuffer[i]==0xff) indexstart=i;
            }
            
            int count = 0;
            indexstart++;
            for (int i=0; i<10;i++) {
            	if (indexstart==11) indexstart=0;
            	freqarray[count] = ringbuffer[indexstart];
            	indexstart++;
            	count++;            	
            }
           
            
        }
		
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			 progressBar1.Value = freqarray[0];
            progressBar2.Value = freqarray[1];
            progressBar3.Value = freqarray[2];
            progressBar4.Value = freqarray[3];
            progressBar5.Value = freqarray[4];
            progressBar6.Value = freqarray[5];
            progressBar7.Value = freqarray[6];
            progressBar8.Value = freqarray[7];
            progressBar9.Value = freqarray[8];
            progressBar10.Value = freqarray[9];
		}
	}
}
