using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace CardDeckRevamp
{
    public partial class LeaderBoardScreen : UserControl
    {
        public LeaderBoardScreen()
        {
            InitializeComponent();
        }

        XmlReader reader = XmlReader.Create("Resources/LeaderboardXML.xml");

        //     while (reader.Read()) 
        //     { 
        //     if (reader.NodeType == XmlNodeType.Text) 
        //     { 
        //         nameLabel.Text += reader.Value + "\n";
        //         timeLabel.Text += reader.Value + "\n";
        //         Name = reader.ReadString();
        //         Name.ReadToNextSibling("Name"); 
        //         Name = reader.ReadString(); 
        //         reader.ReadToNextSibling("Time"); 
        //         Time = reader.ReadString(); 
        //         Time.ReadToNextSibling("Time"); 
        //         Time = reader.ReadString(); 
        //         Player c = new Player(Name, Time);
        //         playerDB.Add(s); 
        //     }
    }
}
