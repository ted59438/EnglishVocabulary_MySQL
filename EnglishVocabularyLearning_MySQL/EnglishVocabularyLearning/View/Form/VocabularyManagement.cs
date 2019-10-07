using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace EnglishVocabularyLearning
{
	public partial class VocabularyManager : Form
	{
		List<string> allVocabulary = new List<string>();

		HashSet<int> unsaveRows = new HashSet<int>();

		public VocabularyManager()
		{
			InitializeComponent();
		}
	}
}
