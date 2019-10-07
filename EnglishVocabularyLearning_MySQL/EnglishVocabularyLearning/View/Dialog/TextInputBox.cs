using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabularyLearning
{
	public partial class TextInputBox : Form
	{
		public string inputText
		{
			get
			{
				return textBox1.Text;
			}
		}
		public TextInputBox(string messageText, string inputText = "")
		{
			InitializeComponent();

			label1.Text = messageText;
			textBox1.Text = inputText;
		}
	}
}
