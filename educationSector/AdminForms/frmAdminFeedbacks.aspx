<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAdminFeedbacks.aspx.cs" Inherits="educationSector.AdminForms.frmAdminFeedbacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="Panel3" runat="server">
             <div class="article">
      <h2><span>STUDENT</span> FEEDBACKS</h2>

                <asp:Panel ID="Panel12" runat="server" HorizontalAlign="Center">
                    <table align="center" style="width: 77%;">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ImageButton ID="ImageButton1_Pending" runat="server" 
                                    ImageUrl="~/images/folder-down-icon.jpg" 
                                    onclick="ImageButton1_Pending_Click" />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:ImageButton ID="ImageButton2_Answered" runat="server" 
                                    ImageUrl="~/images/folder-edit-icon.jpg" 
                                    onclick="ImageButton2_Answered_Click" />
                            </td>
                        </tr>
                        <tr style="font-size: small">
                            <td>
                                <b>Pending</b></td>
                            <td>
                                <b></b>
                            </td>
                            <td>
                                <b>Answered</b></td>
                        </tr>
                        <tr style="font-size: small">
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <asp:Table ID="Table3" runat="server" Font-Size="Small" 
                        HorizontalAlign="Center">
                    </asp:Table>
                    <br />
                    <br />
                </asp:Panel>
                </div>
            </asp:Panel>
</asp:Content>
