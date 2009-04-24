using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DailyMeal.Gateway;
using Ninject.Core;

namespace MealTracker.View
{
    public partial class WF_MainForm : Form
    {
       private IRepository _repository;

    public WF_MainForm()
    {
        InitializeComponent();
    }
       
    [Inject]
    public WF_MainForm(IRepository repository): this()
     {
         _repository = repository;
     }

    }
}
