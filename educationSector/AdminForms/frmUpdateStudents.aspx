<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmUpdateStudents.aspx.cs" Inherits="educationSector.frmUpdateStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 17px;
            width: 218px;
        }
        .style2
        {
            width: 77px;
        }
        .style3
        {
            height: 17px;
            width: 77px;
        }
        .style4
        {
            width: 93px;
        }
        .style5
        {
            width: 238px;
        }
        .style7
        {
            height: 260px;
            width: 189px;
        }
        .style8
        {
            height: 123px;
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:Panel ID="panelAboutus" runat="server">
  <div class="article">
      <h2><span>SEARCH</span> STUDENT</h2>

   	<TABLE id="Table7" cellSpacing="4" cellPadding="2" border="0" 
         style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid;BORDER-LEFT: #006699 1px solid;BORDER-BOTTOM: #006699 1px solid;border: 1px inset #006699; width: 600px">
							<TR>
								<TD class="style4">
									<asp:Label id="Label6" runat="server" Width="100px" Font-Bold="True" 
                                        ForeColor="#006699">Enter Regno :</asp:Label></TD>
								<TD class="style5">
									<asp:TextBox id="TextBox_Search" runat="server" CssClass="txtBox" Width="125px"></asp:TextBox></TD>
								<td class="style5">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                        ControlToValidate="TextBox_Search" ErrorMessage="*" Font-Bold="True" 
                                        ForeColor="#FF3300" ToolTip="Enter Regno" ValidationGroup="sss"></asp:RequiredFieldValidator>
                                </td>
								<TD>
									<asp:Button ID="btnProfile" runat="server" CssClass="Button_Click" 
                                        onclick="btnProfile_Click" Text="Profile" ValidationGroup="sss" Width="75px" />
                                </TD>
							    <td>
                                    <asp:Button ID="btnAttributes" runat="server" CssClass="Button_Click" 
                                        onclick="btnAttributes_Click" Text="Parameters" ValidationGroup="sss" 
                                        Width="120px" />
                                </td>
							    <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
							</TR>
						</TABLE>

  	<TABLE id="Table2" style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid;BORDER-LEFT: #006699 1px solid;BORDER-BOTTOM: #006699 1px solid;WIDTH: 600px; HEIGHT: 634px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" bgColor="#0" border="0">
							<TR>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									align="center" class="style3">Photo</TD>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 109px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 17px; BACKGROUND-COLOR: #006699"
									align="center"><asp:label id="Label1" runat="server" BackColor="Transparent" Width="168px">Profile</asp:label></TD>
							</TR>
							<TR>
								<TD vAlign="top" align="center" class="style2"><TABLE id="Table4" 
                                        style="WIDTH: 225px; HEIGHT: 534px" cellSpacing="0" cellPadding="0" 
                                        border="0">
										<tr>
                                            <td align="center" bgColor="beige" class="style7" vAlign="top">
                                                <img src="../images/ad.png">
                                                </img>
                                            </td>
                                        </tr>
										<TR>
											<TD class="style8">&nbsp;</TD>
										</TR>
									</TABLE>
								</TD>
								<TD vAlign="top" align="left">
									<TABLE id="Table3" style="FONT-SIZE: 12px; COLOR: black; FONT-FAMILY: Verdana" cellSpacing="2"
										cellPadding="3" width="300" border="0">
										<TR>
											<TD style="WIDTH: 93px">Status</TD>
											<TD style="WIDTH: 145px">
                                                <asp:DropDownList ID="DropDownListStatus" runat="server">
                                                    <asp:ListItem>Old</asp:ListItem>
                                                    <asp:ListItem>Current</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
											<TD>
												&nbsp;</TD>
										</TR>
										<tr>
                                            <td style="WIDTH: 93px">
                                                Result</td>
                                            <td style="WIDTH: 145px">
                                                <asp:TextBox ID="txtpStatus" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
										<tr>
                                            <td style="WIDTH: 93px">
                                                Register No</td>
                                            <td style="WIDTH: 145px">
                                                <asp:TextBox ID="TextBox_Reg" runat="server" CssClass="txtBox" ReadOnly="True"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="TextBox_Reg" ErrorMessage="*"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
										<TR>
											<TD style="WIDTH: 93px">Name</TD>
											<TD style="WIDTH: 145px"><asp:textbox id="TextBox_Name" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox_Name"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">DOB</TD>
											<TD style="WIDTH: 145px"><asp:textbox id="TextBox_DOB" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="TextBox_DOB"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">Gender</TD>
											<TD style="WIDTH: 145px"><asp:dropdownlist id="DropDownList_Gender" runat="server" Width="88px" CssClass="txtBox">
													<asp:ListItem Value="Male">Male</asp:ListItem>
													<asp:ListItem Value="Female">Female</asp:ListItem>
												</asp:dropdownlist></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px; BACKGROUND-COLOR: ghostwhite" colSpan="3"><STRONG><asp:label id="Label2" runat="server" BackColor="Transparent" Width="136px">Course Details :</asp:label></STRONG></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">Course name</TD>
											<TD style="WIDTH: 145px">
                                                <asp:DropDownList ID="DropDownList_Course" runat="server" CssClass="txtBox">
                                                </asp:DropDownList>
                                            </TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">Semister</TD>
											<TD style="WIDTH: 145px"><asp:dropdownlist id="DropDownList_Sem" runat="server" Width="64px" CssClass="txtBox"></asp:dropdownlist></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px; HEIGHT: 20px; BACKGROUND-COLOR: ghostwhite" colSpan="3"><asp:label id="Label4" runat="server" Width="136px" Font-Bold="True">Parent Information :</asp:label></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">Parent Name</TD>
											<TD style="WIDTH: 145px"><asp:textbox id="TextBox_Parent" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="TextBox_Parent"></asp:RequiredFieldValidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px; HEIGHT: 7px">Email Id</TD>
											<TD style="WIDTH: 145px; HEIGHT: 7px"><asp:textbox id="TextBox_Email" 
                                                    runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD style="HEIGHT: 7px">
												<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox_Email"
													ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px; HEIGHT: 20px">Mobile No.</TD>
											<TD style="WIDTH: 145px; HEIGHT: 20px" align="center"><asp:textbox id="TextBox_Mobile" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD style="HEIGHT: 20px"></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px; HEIGHT: 20px">Password</TD>
											<TD style="WIDTH: 145px; HEIGHT: 20px" align="center">
                                                <asp:textbox id="Txtpassword" 
                                                    runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD style="HEIGHT: 20px">&nbsp;</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 246px; HEIGHT: 20px" vAlign="middle" align="center" colSpan="2">
                                                <asp:panel id="PanelUpdate" runat="server" Width="237px" BorderStyle="Solid" BorderWidth="1px"
													Height="108px">
													<TABLE id="Table5" style="FONT-SIZE: 12px; WIDTH: 223px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 100px"
														cellSpacing="0" cellPadding="0" width="223" border="0">
														<TR>
															<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 113px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #FF9933"
																colSpan="3">
																<asp:Label id="Label5" runat="server" Width="208px">Change 
                                                                Password :</asp:Label></TD>
														</TR>
														<TR>
															<TD class="style1">old</TD>
															<td class="style1">
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                            ControlToValidate="TextBox_OldPwd" ErrorMessage="*"></asp:RequiredFieldValidator>
															</td>
															<TD>
																<asp:TextBox id="TextBox_OldPwd" runat="server" CssClass="txtBox" Width="137px" Height="20px"
																	TextMode="Password"></asp:TextBox></TD>
														</TR>
														<TR>
															<TD class="style1">new</TD>
															<td class="style1">
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                            ControlToValidate="TextBox_NewPwd" ErrorMessage="*"></asp:RequiredFieldValidator>
                                                            </td>
															<TD>
																<asp:TextBox id="TextBox_NewPwd" runat="server" CssClass="txtBox" Width="137" Height="20" TextMode="Password"></asp:TextBox></TD>
														</TR>
														<TR>
															<TD class="style1">confirm</TD>
															<td class="style1">
                                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                            ControlToCompare="TextBox_NewPwd" ControlToValidate="TextBoxConfirm" 
                                                            ErrorMessage="*"></asp:CompareValidator>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                            ControlToValidate="TextBoxConfirm" ErrorMessage="*"></asp:RequiredFieldValidator>
                                                            </td>
															<TD>
																<asp:TextBox id="TextBoxConfirm" runat="server" CssClass="txtBox" Width="137" Height="20" TextMode="Password"></asp:TextBox></TD>
														</TR>
														<TR>
															<TD align="right" class="style1"></TD>
															<TD align="right" class="style1">&#160;</TD>
															<td align="center">
																<asp:Button ID="Button1" runat="server" CssClass="Button_Click" 
                                                            onclick="Button1_Click" Text="Change" Width="60px"></asp:Button>&#160;
																<asp:Button ID="Button2" runat="server" CausesValidation="False" 
                                                            CssClass="Button_Click" onclick="Button2_Click" Text="Cancel" Width="59px">
                                                        </asp:Button></td>
															<TD align="center"></TD>
														</TR>
													</TABLE>
												</asp:panel><asp:panel id="PanelChange" runat="server" Width="232px" Height="12px">
                  <TABLE id="Table6" style="WIDTH: 235px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="235"
														border="0">
														<TR>
															<TD></TD>
															<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
																<asp:Button id="Button3" runat="server" CssClass="Button_Click" Width="109px" Text="Change Password" onclick="Button3_Click"></asp:Button></TD>
														</TR>
													</TABLE>&nbsp; 
                  </asp:panel></TD>
											<TD style="HEIGHT: 20px"></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px"></TD>
											<TD style="WIDTH: 145px" align="right">&nbsp;</TD>
											<TD></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 93px">&nbsp;</TD>
											<TD style="WIDTH: 145px" align="right">
                                                <asp:Button ID="btnUpdate" runat="server" CssClass="Button_Click" onclick="btnUpdate_Click" 
                                                    Text="Update Student" />
                                            </TD>
											<TD>&nbsp;</TD>
										</TR>
									    <tr>
                                            <td style="WIDTH: 93px">
                                                &nbsp;</td>
                                            <td align="right" style="WIDTH: 145px">
                                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td style="WIDTH: 93px">
                                                &nbsp;</td>
                                            <td align="right" style="WIDTH: 145px">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									</TABLE>
								</TD>
							</TR>
						</TABLE>

</div>
   </asp:Panel>


</asp:Content>
