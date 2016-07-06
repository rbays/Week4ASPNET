using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void ButtonName_Click(object sender, EventArgs e)
    {
        String name = nameBox.Text;
        nameOutLabel.Text = "Hello, " + name;
    }

    protected void ButtonCheck_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            checkBoxOut.Text = "The box is checked";
        }
        else
        {
            checkBoxOut.Text = "The box is not checked";
        }
    }

    protected void ButtonRadio_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem == null)
        {
            radioOut.Text = "nothing selected";
        }
        else {
            radioOut.Text = "you selected " + RadioButtonList1.SelectedValue;
        }
    }

    protected void ButtonDropDown_Click(object sender, EventArgs e)
    {
        LabelDropDown.Text = "you have selected " + DropDownList1.SelectedValue;
    }

    protected void ButtonIcecream_Click(object sender, EventArgs e)
    {
        String output = "You like: ";
        foreach(ListItem li in CheckBoxListIcecream.Items)
        {
           if (li.Selected)
            {
                output += li.Value + " ";
            }
            
        }
        LabelIcecream.Text = output;
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            checkBoxOut.Text = "The box is checked";
        }
        else
        {
            checkBoxOut.Text = "The box is not checked";
        }
    }

    protected void ButtonEmail_Click(object sender, EventArgs e)
    {
        
    }

    protected void ButtonTextLength_Click(object sender, EventArgs e)
    {
        string myText = TextBoxLength.Text;
        int length = myText.Length;
        LabelTextLength.Text = "Length: " + length;
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        
    }

    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
        LabePikachu.Text = "ZAP!!!";
    }

    protected void ButtonCalendar_Click(object sender, EventArgs e)
    {
        LabelCalendar.Text = Calendar1.SelectedDate.ToLongDateString();
    }

    protected void ButtonValidate_Click(object sender, EventArgs e)
    {
        if (requiredVal.IsValid==false)
        {
            ButtonValidate.Text = "Enter a string";
        }
        else if(RegularExpressionValidator1.IsValid==false)
        {
            ButtonValidate.Text = "not a valid email";
        }
        else
        {
            ButtonValidate.Text = "YAY!!!";
        }
    }
}