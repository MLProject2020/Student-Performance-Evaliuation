<%@ Page Title="" Language="C#" MasterPageFile="~/GuestForms/MainMasterpage.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="educationSector.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelLogin" runat="server">
    <div class="article">
      <h2><span>LOGIN</span> FORM FOR USERS</h2>

   
   <TABLE id="Table1" cellSpacing="0" cellPadding="0" width="900px" border="0">
				<TR>
					<TD style="vAlign="top" align="left">
						<TABLE id="Table2" style="cellSpacing="1" cellPadding="1"
							border="0">
							<TR>
								<TD vAlign="middle" align="left">
                                    <table id="Table3" border="0" cellpadding="1" cellspacing="1" 
                                        
                                        style="border-style: 1; border-color: #666666; border-width: 1px; WIDTH: 277px; " 
                                        width="277">
                                        <tr>
                                            <td style="border-style: 1; border-color: #666666; border-width: 1px; FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 6px; BACKGROUND-COLOR: #006699">
                                                <b>Choose Login Type :</b></td>
                                            <td style="border-style: 1; border-color: #666666; border-width: 1px; FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 6px; BACKGROUND-COLOR: #006699">
                                                &nbsp;</td>
                                            <td style="border-style: 1; border-color: #666666; border-width: 1px; FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 6px; BACKGROUND-COLOR: #006699">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="BORDER-RIGHT: #006699 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 3px groove; HEIGHT: 116px; border-color: #006699 #006699 #006699 #006699;" 
                                                valign="top">
                                                <table id="Table4" border="0" cellpadding="1" cellspacing="2" 
                                                    style="FONT-SIZE: 12px; WIDTH: 189px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: 119px" 
                                                    width="189">
                                                    <tr>
                                                        <td style="HEIGHT: 13px">
                                                            &nbsp;</td>
                                                        <td style="HEIGHT: 13px">
                                                            &nbsp;</td>
                                                        <td style="HEIGHT: 13px">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="HEIGHT: 13px">
                                                            <b>Select</b></td>
                                                        <td style="HEIGHT: 13px">
                                                            <asp:DropDownList ID="DropDown_Type" runat="server" CssClass="txtBox" 
                                                                Width="128px">
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td style="HEIGHT: 13px">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>UserId</b>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="Txt_User" runat="server" CssClass="txtBox" Width="162px"></asp:TextBox>
                                                        </td>
                                                        <td align="center" valign="middle">
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                ControlToValidate="Txt_User" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Password</b>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="Txt_Password" runat="server" CssClass="txtBox" 
                                                                TextMode="Password" Width="162px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                ControlToValidate="Txt_Password" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td align="right">
                                                            &nbsp;</td>
                                                        <td align="right">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td align="right">
                                                            <asp:Button ID="Button_Login" runat="server" CssClass="Button_Click" 
                                                                onclick="Button_Login_Click" Text="Login" Width="86px" />
                                                        </td>
                                                        <td align="right">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center" colspan="2">
                                                            <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="BORDER-RIGHT: #669900 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 3px groove; HEIGHT: 116px; border-color: #006699 #006699 #006699 #006699;" 
                                                valign="middle">
                                                &nbsp;</td>
                                            <td style="BORDER-RIGHT: #669900 1px solid; BORDER-TOP: #006699 1px solid; BORDER-LEFT: #006699 1px solid; BORDER-BOTTOM: #006699 3px groove; HEIGHT: 116px; border-color: #006699 #006699 #006699 #006699;" 
                                                valign="middle">
                                                <asp:Image ID="Image1" runat="server" Height="200px" 
                                                    ImageUrl="~/images/education4.png" Width="365px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" valign="middle">
                                                &nbsp;</td>
                                            <td align="center" valign="middle">
                                                &nbsp;</td>
                                            <td align="center" valign="middle">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				</TABLE>

                </div>
   </asp:Panel>


</asp:Content>
