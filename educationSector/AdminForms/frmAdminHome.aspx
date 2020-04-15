<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAdminHome.aspx.cs" Inherits="educationSector.frmAdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Panel ID="panelAdminHome" runat="server">
  <div class="article">
      <h2><span>WELCOME TO ADMIN</span> HOME</h2>


<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD style="HEIGHT: 10px;>
						&nbsp;</TD>
				</TR>
				<TR>
					<TD style="BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; HEIGHT: 21px; BORDER-BOTTOM-STYLE: none">
					
                             <marquee scrolldelay="150" behavior="alternate">   <asp:Label ID="LabelUser" runat="server" CssClass="userLabel" Font-Bold="True" 
                                    Font-Size="Medium"></asp:Label> </marquee>
                           
                    </TD>
				</TR>
				<TR>
					<TD style="height: 10px;" 21px;="" border-bottom-style:="" 
                        border-left-style:="" border-right-style:="" border-top-style:="" height:="" 
                        none"="" none;="" none;="" none;="">
						&nbsp;</TD>
				</TR>
				
			    <tr>
                    <td align="center" 
                        style="BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none" 
                        valign="middle">
                        <table id="Table2" border="0" cellpadding="0" cellspacing="0" 
                            style="border-color: #006699; BORDER-TOP-WIDTH: 1px; FONT-WEIGHT: normal; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; BORDER-BOTTOM-WIDTH: 1px; WIDTH: 583px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 309px; BORDER-RIGHT-WIDTH: 1px; " 
                            width="900px">
                            <tr>
                                <td align="left" colspan="2" 
                                    style="BORDER-RIGHT: #006699 1px solid; BORDER-LEFT: #006699 1px solid;FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 170px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699" 
                                    valign="middle">
                                    <asp:Label ID="Label1" runat="server">Adminsitrator Tasks :</asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" 
                                    style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; WIDTH: 170px; BORDER-BOTTOM: #006699 1px solid" 
                                    valign="middle">
                                    <asp:Image ID="Image1" runat="server" Height="300px" 
                                        ImageUrl="~/images/lib.png" Width="250px" />
                                </td>
                                <td align="center" colspan="1" rowspan="2" 
                                    style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 1px solid; border-color: #006699;" 
                                    valign="top">
                                    <br />

                                    <marquee scrolldelay="150" direction="up">
          <img src="../images/education5.png"" width="260" height="100" alt="" /> &nbsp
          <img src="../images/educational1.jpg" width="260" height="100" alt="" /> &nbsp
         <img src="../images/ebsl_section_courses.jpg" width="260" height="100" alt="" /> &nbsp
          </marquee>


                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
				
			</TABLE>
            </div>
            </asp:Panel>

</asp:Content>
