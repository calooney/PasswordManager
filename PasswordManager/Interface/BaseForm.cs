/****************************************************************************
 *                                                                          *
 *  File:        BaseForm.cs                                                *
 *  Copyright:   (c) 2022, Tarziu Matei-Stefan                              *
 *  E-mail:      matei-stefan.tarziu@student.tuiasi.ro                      *
 *  Description: In this file you will find the implementation for          *
 *               a BaseForm class that will be used to inherit              *
 *               Form proprieties to all uset Form in application.          *
 *                                                                          *
 ****************************************************************************/

using System.Windows.Forms;

namespace Interface
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
