﻿using Npgsql.PostgresTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоомагаз
{
    public partial class Categories : UserControl
    {
       // private int id { get; set; }
        private string name { get; set; } 

        public Categories(string name)
        {
            InitializeComponent();

          //  this.id = id;  
            this.name = name;

            button2.Text = name;
        }
        
    }
}
