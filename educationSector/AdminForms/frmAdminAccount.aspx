<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAdminAccount.aspx.cs" Inherits="educationSector.frmAdminAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 338px;
        }
        .style3
        {
            width: 170px;
        }
        .style5
        {
            height: 1px;
        }
        .style11
        {
            width: 261px;
        }
        .style12
        {
            width: 426px;
        }
        .style13
        {
            width: 147px;
        }
        .style14
        {
            width: 147px;
            height: 68px;
        }
        .style15
        {
            width: 426px;
            height: 68px;
        }
        .style16
        {
            width: 261px;
            height: 68px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelAboutus" runat="server">
  <div class="article">
      <h2><span>ADMIN</span> ACCOUNT</h2>


   	<TABLE id="Table2" style="border-width: 1px; border-color: #006699; FONT-WEIGHT: normal; FONT-SIZE: 12px; WIDTH: 640px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 280px; "
							cellSpacing="0" cellPadding="0" border="0">
							<TR>
								<TD style="border: 1px solid #006699; FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									vAlign="middle" align="left" colSpan="2" class="style5">
									<asp:Label id="Label4" runat="server">Change Password :</asp:Label></TD>
							</TR>
							<TR>
								<TD style="border: 1px solid #006699;"
									vAlign="middle" align="center" class="style3">
                                    <IMG style="WIDTH: 232px; HEIGHT: 261px" height="261" src="../images/ad.png"
										width="232" border="0"></TD>
								<TD vAlign="middle" align="center" colSpan="1" rowSpan="2" 
                                    style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid" 
                                    class="style1">
									<TABLE id="Table3" style="BORDER-TOP: 2px double #006699; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; width: 404px; color: black; border-bottom: 2px groove #006699; font-family: Verdana; height: 139px; border-right-width: 1px; border-left-color: #666666; border-right-color: #666666;"
										cellSpacing="2" cellPadding="2" border="0">
										<TR>
											<TD class="style13">
												<asp:Label id="Label1" runat="server" Width="88px">Old Password</asp:Label></TD>
											<TD class="style12">
												<asp:TextBox id="TextBox1" runat="server" Width="161px" CssClass="txtBox" Height="20px" TextMode="Password"></asp:TextBox></TD>
											<TD class="style11">
												<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD class="style13">
												<asp:Label id="Label2" runat="server" Width="96px">New Password</asp:Label></TD>
											<TD class="style12">
												<asp:TextBox id="TextBox2" runat="server" Width="161" CssClass="txtBox" Height="20" TextMode="Password"></asp:TextBox></TD>
											<TD class="style11">
												<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                    ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                                            </TD>
										</TR>
										<TR>
											<TD class="style13">
												<asp:Label id="Label3" runat="server" Width="96px">Confirm</asp:Label></TD>
											<TD class="style12">
												<asp:TextBox id="TextBox3" runat="server" Width="161" CssClass="txtBox" Height="20" TextMode="Password"></asp:TextBox></TD>
											<TD class="style11">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="*"></asp:CompareValidator>
                                            </TD>
										</TR>
										<TR>
											<TD class="style13">&nbsp;</TD>
											<TD align="right" class="style12">
												<asp:Button id="Button1" runat="server" Width="73px" CssClass="Button_Click" Text="Change" onclick="Button1_Click"></asp:Button>&nbsp;</TD>
											<TD align="right" class="style11">&nbsp;</TD>
										</TR>
									</TABLE>
								    <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                        ControlToValidate="TextBox2" Display="Dynamic" 
                                        ErrorMessage="Password Must be 8 Characters including 1 Uppercase letter, 1 Special Character and Alphanumeric Characters." 
                                        ForeColor="#FF3300" 
                                        ToolTip="Password Must be 8 Characters including 1 Uppercase letter, 1 Special Character and Alphanumeric Characters." 
                                        ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">Password 
                                    Must be 8 Characters including 1 Uppercase letter, 1 Special Character and 
                                    Alphanumeric Characters.</asp:RegularExpressionValidator>
								</TD>
							</TR>
						</TABLE>
</div>
   </asp:Panel>


</asp:Content>
