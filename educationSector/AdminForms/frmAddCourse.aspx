<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAddCourse.aspx.cs" Inherits="educationSector.frmAddCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="panelAddCourse" runat="server">
  <div class="article">
      <h2><span>MANAGE</span> COURSES</h2>


   	<TABLE id="Table2" style="border-color: #006699; BORDER-TOP-WIDTH: 1px; FONT-WEIGHT: normal; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; BORDER-BOTTOM-WIDTH: 1px; WIDTH: 640px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 367px; BORDER-RIGHT-WIDTH: 1px; "
							cellSpacing="0" cellPadding="0" width="696" border="0">
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; FONT-WEIGHT: bold; FONT-SIZE: 12px; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; COLOR: white; BORDER-BOTTOM: #006699 1px solid; FONT-FAMILY: Verdana; HEIGHT: 17px; BACKGROUND-COLOR: #006699"
									vAlign="middle" align="left" colSpan="1">
									Manage
									<asp:Label id="Label4" runat="server">Courses :</asp:Label></TD>
								<TD style="HEIGHT: 17px; BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid;BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid;BACKGROUND-COLOR: #006699" vAlign="middle" 
                                    align="center"></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; BORDER-BOTTOM: #006699 1px solid"
									vAlign="middle" align="center" colSpan="1">
                                    <IMG style="WIDTH: 275px; HEIGHT: 340px" src="../images/libraian.png"></TD>
								<TD vAlign="middle" align="center" colSpan="1" rowSpan="2" style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid">
									<TABLE id="Table3" style="BORDER-TOP: #006699 2px double; WIDTH: 202px; BORDER-BOTTOM: #006699 2px groove; HEIGHT: 175px; border-top-color: #006699; border-bottom-color: #006699;"
										cellSpacing="3" cellPadding="1" width="202" border="0">
										<TR>
											<TD style="HEIGHT: 10px" align="left">
                                                <asp:Label ID="Label5" runat="server" Width="176px">Course Name :</asp:Label>
                                            </TD>
										</TR>
										<TR>
											<TD align="left"><asp:textbox id="TextBox_Course" runat="server" CssClass="txtBox"></asp:textbox>
												<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ControlToValidate="TextBox_Course" ErrorMessage="*Enter Course name" 
                                                    ForeColor="#FF3300" Height="16px" Width="139px"></asp:RequiredFieldValidator>
												</TD>
										</TR>
										<tr>
                                            <td align="left" valign="bottom" class="style1">
                                                <asp:Label ID="Label2" runat="server" Width="176px">No. of semisters :</asp:Label>
                                            </td>
                                        </tr>
										<TR>
											<TD vAlign="top" align="left"><asp:dropdownlist id="DropDownList1" runat="server" CssClass="txtBox" Width="104px"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD align="left"><asp:label id="Label3" runat="server" Width="138px">Course 
                                                Description :</asp:label></TD>
										</TR>
										<TR>
											<TD align="left"><asp:textbox id="TextBox_Desc" runat="server" Width="296px" CssClass="txtBox" TextMode="MultiLine"
													Height="132px"></asp:textbox></TD>
										</TR>
										<TR>
											<TD vAlign="top" align="left">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="TextBox_Desc" ErrorMessage="Enter Desc" ForeColor="#FF3300" 
                                                    Height="16px" ToolTip="Enter Desc" Width="139px"></asp:RequiredFieldValidator>
											</TD>
										</TR>
									    <tr>
                                            <td align="center" valign="top">
                                                &nbsp;&nbsp;<asp:Label ID="LabelMessage" runat="server" BorderColor="Transparent" 
                                                    Font-Names="Verdana" Font-Size="X-Small" ForeColor="Black"></asp:Label>
                                                &nbsp;
                                                <table id="Table4" border="0" cellpadding="0" cellspacing="1" 
                                                    style="WIDTH: 193px; HEIGHT: 26px" width="193">
                                                    <tr>
                                                        <td>
                                                            <asp:Button ID="Button_Add" runat="server" CssClass="Button_Click" 
                                                                onclick="Button_Add_Click" Text="Add" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="Button_Delete" runat="server" CssClass="Button_Click" 
                                                                onclick="Button_Delete_Click" Text="Delete" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="Button_Update" runat="server" CssClass="Button_Click" 
                                                                onclick="Button_Update_Click" Text="Update" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="ButtonView" runat="server" CausesValidation="False" 
                                                                CssClass="Button_Click" onclick="ButtonView_Click" Text="View All" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
</div>
   </asp:Panel>

</asp:Content>
