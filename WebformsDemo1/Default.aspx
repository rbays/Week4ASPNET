<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>

    <form id="form1" runat="server">
    <div>
       <h3>My very first ASP.NET Web Forms page<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
           <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:Button ID="ButtonCalendar" runat="server" Text="Button" OnClick="ButtonCalendar_Click" />
           <asp:Label ID="LabelCalendar" runat="server" Text=""></asp:Label>
          
        </h3>
        
        <asp:BulletedList ID="BulletedList1" runat="server" BulletImageUrl="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACcAAAAgCAMAAACmeJG/AAAAJ1BMVEX///8AAAAYGBghISkICAhCQlK9vb1SUlqMnNbG3vdCSmMYGDnW3vch+DXhAAABJ0lEQVQ4jY3UAQ6DIAwFUAqopeX+590vFgSdiT8uirwBIhjC15DnuvLi3cUWGldevlu67q/OfovbLZQ21OyeSLVSSpFmt1kIR0ybR2qoZYUUD4u5dPTA3WHvFzT1bncp4Q69lmyIqwuiE/zrqHWshNqY6d3tWppDeoOzG89xKBfrV4XJG/Ta9hyXSw3aswC6G/M3pg9xCOYjfHGAwlC0vbpEgiScobb06qiGIsVLabiYLOf7bRGMSoKtgzOrw+FO0Zw16TC+usKK+RDWpvr8PRydLFRW1bEJ+no219dyQYs2xYqJZqHw5vhiZbg8XHaXSdkYT+yfA2Trmic2XM6TA2S8FRa51n0+W5hcRh77nXJLc4/M+9LvIA+17PPxT1rN/bvx8Tv0LT/diQ8+hiJ44AAAAABJRU5ErkJggg==" BulletStyle="CustomImage">
            <asp:ListItem>Tom</asp:ListItem>
            <asp:ListItem>Dick</asp:ListItem>
            <asp:ListItem>Harry</asp:ListItem>
        </asp:BulletedList>
        
    </div>
    <div>
        <asp:Label ID="nameInstructions" runat="server" Text="Label">Please type in your name:</asp:Label>
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonName" runat="server" Text="Click me" OnClick="ButtonName_Click" />
        <br />
        <asp:Label ID="nameOutLabel" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="checkBoxInstructions" runat="server" Text="Label">Please check or uncheck the box:</asp:Label><br />
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" /><br />
        <asp:Button ID="ButtonCheck" runat="server" Text="Check Box Button" OnClick="ButtonCheck_Click" /><br />
        <asp:Label ID="checkBoxOut" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="radioInstructions" runat="server" Text="Label">Please click the radio button:</asp:Label><br />
        
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="ButtonRadio" runat="server" Text="Radio Button!" OnClick="ButtonRadio_Click" /><br />
        <asp:Label ID="radioOut" runat="server" Text=""></asp:Label>
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>JavaScript</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonDropDown" runat="server" Text="Button" OnClick="ButtonDropDown_Click" />
        <asp:Label ID="LabelDropDown" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxListIcecream" runat="server">
            <asp:ListItem>Vanilla</asp:ListItem>
            <asp:ListItem>Chocolate</asp:ListItem>
            <asp:ListItem>Strawberry</asp:ListItem>
        </asp:CheckBoxList>
        
        <br />
        <asp:Button ID="ButtonIcecream" runat="server" Text="ICECREAM!!" OnClick="ButtonIcecream_Click" />
        <asp:Label ID="LabelIcecream" runat="server" Text=""></asp:Label>

        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" href ="HTTP://www.netflix.com">LinkButton</asp:LinkButton>
        </p>

        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter an email address: "></asp:Label>

        </p>

       <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredVal" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter your email!"></asp:RequiredFieldValidator> 
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
             ErrorMessage="Invalid Email" ControlToValidate="TextBox7"
             SetFocusOnError="True"
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
</asp:RegularExpressionValidator>

              
        <asp:Button ID="ButtonValidate" runat="server" Text="Button" OnClick="ButtonValidate_Click" />

              
        <br />
        <asp:TextBox ID="TextBoxLength" runat="server" Height="100" Width="250"></asp:TextBox>
        <asp:Button ID="ButtonTextLength" runat="server" Text="Button" OnClick="ButtonTextLength_Click" />
        <asp:Label ID="LabelTextLength" runat="server" Text="Length: "></asp:Label>

        <p>

        <asp:ImageButton ID="ImageButton1"  runat="server" src ="http://cdn.bulbagarden.net/upload/thumb/0/0d/025Pikachu.png/250px-025Pikachu.png" OnClientClick ="window.location.href='http://www.google.com/'; return false;"/>
        
        </p>
        
        <asp:ImageMap ID="ImageMap1" runat="server" src="https://pbs.twimg.com/profile_images/556163239197675520/3mSPGH6p.png" OnClick="ImageMap1_Click">
            <asp:CircleHotSpot HotSpotMode="PostBack" Radius="15" X="178" Y="165" />
            <asp:CircleHotSpot HotSpotMode="PostBack" Radius="15" X="303" Y="148" />
        </asp:ImageMap>
        
        <asp:Label ID="LabePikachu" runat="server" Text=""></asp:Label>
        
    </form>
   


</body>
</html>
