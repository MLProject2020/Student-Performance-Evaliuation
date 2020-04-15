<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmDataset.aspx.cs" Inherits="educationSector.AdminForms.frmDataset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="article">
      <h2><span>STUDENT</span> DATASET </h2>


<br />
    <TABLE id="Table1" style="BORDER-RIGHT: dimgray 1px solid; BORDER-TOP: dimgray 1px solid; BORDER-LEFT: dimgray 1px solid; WIDTH: 600px; BORDER-BOTTOM: dimgray 1px solid; HEIGHT: 488px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" bgColor="#0" border="0">
							<TR>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 109px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 17px; BACKGROUND-COLOR: #006699"
									align="left"><strong class=" ">
                                        <asp:Label ID="Label4" runat="server" Width="150px">Student Data</asp:Label>
                                    </strong></TD>
							</TR>
							<TR>
								<TD vAlign="top" align="left">
									<TABLE id="Table4" style="FONT-SIZE: 12px;  WIDTH: 300px; COLOR: black; FONT-FAMILY: Verdana" cellSpacing="2"
										 cellPadding="3" border="0">
										<tr>
                                            <td class="style5">
                                               <b> Course </b></td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownList_Course" runat="server" AutoPostBack="True" 
                                                    CssClass="txtBox" 
                                                    Width="150px" Height="30px" 
                                                    onselectedindexchanged="DropDownList_Course_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                <b>Sem</b></td>
                                            <td align="left" class="style4">
                 <asp:DropDownList ID="DropDownList_Sem" runat="server" CssClass="txtBox">
                 </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                               
                                                <asp:Button ID="btnDataset" runat="server" Height="50px" 
                                                    onclick="btnDataset_Click" Text="Dataset" Width="100px" />
                                                </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    </TABLE>
								    <br />
                              <asp:Label ID="lblDataset" runat="server"></asp:Label>
                                            <br />
                                    <br />
                               <asp:Table ID="tableDataset" runat="server">
                              </asp:Table>
								</TD>
							</TR>
						</TABLE>

    <br />
   
      
    </div>
</asp:Content>
