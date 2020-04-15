<%@ Page Title="" Language="C#" MasterPageFile="~/StudentForms/StudentMasterpage.Master" AutoEventWireup="true" CodeBehind="frmStudentAccount.aspx.cs" Inherits="educationSector.frmStudentAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelAboutus" runat="server">
   <div class="article">
      <h2><span>STUDENT</span> ACCOUNT</h2>

   	<TABLE id="Table2" style="BORDER-TOP-WIDTH: 1px; FONT-WEIGHT: normal; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; BORDER-LEFT-COLOR: #006699; BORDER-BOTTOM-WIDTH: 1px; BORDER-BOTTOM-COLOR: #006699; WIDTH: 583px; COLOR: #000000; BORDER-TOP-COLOR: #006699; FONT-FAMILY: Verdana; HEIGHT: 309px; BORDER-RIGHT-WIDTH: 1px; BORDER-RIGHT-COLOR: #666666"
							cellSpacing="0" cellPadding="0" width="583" border="0">
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; BORDER-BOTTOM: 006699 1px solid;FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 170px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									vAlign="middle" align="left" colSpan="2">
									<asp:Label id="Label1" runat="server">Change Password</asp:Label></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; BORDER-BOTTOM: 006699 1px solid"
									vAlign="middle" align="center">
                                    <IMG style="WIDTH: 243px; HEIGHT: 300px" 
                                        height="300" src="../images/education4.png"
										width="243"></TD>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid"
									vAlign="middle" align="center" colSpan="1" rowSpan="2">
									<TABLE id="Table3" style="BORDER-TOP: #006699 2px double; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; BORDER-LEFT-COLOR: #006699; WIDTH: 275px; COLOR: black; BORDER-BOTTOM: #006699 2px groove; FONT-FAMILY: Verdana; HEIGHT: 133px; BORDER-RIGHT-WIDTH: 1px; BORDER-RIGHT-COLOR: #006699"
										cellSpacing="2" cellPadding="2" width="275" border="0">
										<TR>
											<TD>
												<asp:Label id="Label4" runat="server" Width="88px">Old Password</asp:Label></TD>
											<TD>
												<asp:TextBox id="TextBox1" runat="server" CssClass="txtBox_Parent" Width="161px" Height="20px"
													TextMode="Password"></asp:TextBox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="Label2" runat="server" Width="96px">New Password</asp:Label></TD>
											<TD>
												<asp:TextBox id="TextBox2" runat="server" CssClass="txtBox_Parent" Width="161" Height="20" TextMode="Password"></asp:TextBox></TD>
											<TD>
												<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                                    ControlToValidate="TextBox2" 
                                                    ErrorMessage="Password Must be 8 Characters including 1 Uppercase letter, 1 Special Character and Alphanumeric Characters." 
                                                    ForeColor="#FF3300" 
                                                    ToolTip="Password Must be 8 Characters including 1 Uppercase letter, 1 Special Character and Alphanumeric Characters." 
                                                    ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">*</asp:RegularExpressionValidator>
                                            </TD>
										</TR>
										<TR>
											<TD>
												<asp:Label id="Label3" runat="server" Width="96px">Confirm</asp:Label></TD>
											<TD>
												<asp:TextBox id="TextBox3" runat="server" CssClass="txtBox_Parent" Width="161" Height="20" TextMode="Password"></asp:TextBox></TD>
											<TD>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="*"></asp:CompareValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                    ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
                                            </TD>
										</TR>
										<TR>
											<TD></TD>
											<TD align="right">
												<asp:Button id="Button1" runat="server" CssClass="Button_Parent" Width="73px" Text="Change" onclick="Button1_Click"></asp:Button>&nbsp;</TD>
											<TD align="right"></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
</div>
   </asp:Panel>
</asp:Content>
