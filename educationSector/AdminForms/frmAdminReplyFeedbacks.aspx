<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmAdminReplyFeedbacks.aspx.cs" Inherits="educationSector.AdminForms.frmAdminReplyFeedbacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">
      <div class="article">
      <h2><span>REPLY</span> TO FEEDBACKS</h2>

        <table align="center" 
            
            style="border: thin double #17556B; width: 77%; background-image: url('images/body.jpg');">
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small; text-align: left;">
                    <b>Username</b></td>
                <td style="text-align: left; width: 403px">
                    <asp:TextBox ID="txt_name" runat="server" ReadOnly="True" Width="400px" 
                        Font-Size="Small"></asp:TextBox>
                </td>
                <td style="width: 39px; text-align: left;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txt_name" ErrorMessage="*" Font-Size="Small" 
                        ToolTip="field required" ValidationGroup="answer"></asp:RequiredFieldValidator>
                </td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small; text-align: left;">
                    &nbsp;</td>
                <td style="text-align: left; width: 403px">
                    &nbsp;</td>
                <td style="width: 39px; text-align: left;">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small; text-align: left;">
                    <b>Question</b></td>
                <td style="text-align: left; width: 403px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="99px" ReadOnly="True" 
                        TextMode="MultiLine" Width="400px" Font-Size="Small"></asp:TextBox>
                </td>
                <td style="width: 39px; text-align: left;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="*" Font-Size="Small" 
                        ToolTip="field required" ValidationGroup="answer"></asp:RequiredFieldValidator>
                </td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small; text-align: left;">
                    &nbsp;</td>
                <td style="text-align: left; width: 403px">
                    &nbsp;</td>
                <td style="width: 39px; text-align: left;">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small; text-align: left;">
                    <b>Answer</b></td>
                <td style="text-align: left; width: 403px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="115px" TextMode="MultiLine" 
                        Width="400px" Font-Size="Small"></asp:TextBox>
                </td>
                <td style="width: 39px; text-align: left;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="*" ToolTip="field required" 
                        ValidationGroup="answer" Font-Size="Small"></asp:RequiredFieldValidator>
                </td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td align="right" style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699; font-size: small;">
                    &nbsp;</td>
                <td align="right" style="width: 403px">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="60px" 
                        ImageUrl="~/images/EditIcon.jpg" onclick="ImageButton1_Click" 
                        ValidationGroup="answer" Width="60px" />
                </td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699">
                    &nbsp;</td>
                <td align="left" style="width: 403px">
                    <asp:Label ID="lbl_msg" runat="server" Font-Bold="True" Font-Size="Small"></asp:Label>
                </td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 84px; color: #006699">
                    &nbsp;</td>
                <td style="width: 42px; color: #006699">
                    &nbsp;</td>
                <td style="width: 76px; color: #006699">
                    &nbsp;</td>
                <td align="right" style="width: 403px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td style="width: 39px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
     </div>
    </asp:Panel>
</asp:Content>
