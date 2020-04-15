<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="IndividualPrediction.aspx.cs" Inherits="educationSector.AdminForms.IndividualPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="panelAboutus" runat="server">
  <div class="article">
      <h2><span>ENTER</span> STUDENT PARAMETERS</h2>

   <br />
    <TABLE id="Table2" style="BORDER-RIGHT: dimgray 1px solid; BORDER-TOP: dimgray 1px solid; BORDER-LEFT: dimgray 1px solid; WIDTH: 600px; BORDER-BOTTOM: dimgray 1px solid; HEIGHT: 488px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" width="418" bgColor="#0" border="0">
							<TR>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: white; FONT-FAMILY: Verdana; BACKGROUND-COLOR: #006699"
									align="center" class="style3">
                                    <asp:Label ID="Label1" runat="server" BackColor="Transparent" Width="168px">&nbsp;&nbsp;&nbsp;&nbsp; 
                                   </asp:Label>
                                </TD>
								<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12px; WIDTH: 109px; COLOR: white; FONT-FAMILY: Verdana; HEIGHT: 17px; BACKGROUND-COLOR: #006699"
									align="left"><strong class=" ">
                                        <asp:Label ID="Label3" runat="server" Width="150px">Student Parameters</asp:Label>
                                    </strong></TD>
							</TR>
							<TR>
								<TD vAlign="top" align="center" class="style3">
									<TABLE id="Table4" style="WIDTH: 175px; HEIGHT: 534px" cellSpacing="0" 
                                        cellPadding="0" border="0">
										<TR>
											<TD style="HEIGHT: 260px" align="center" bgcolor="beige" valign="bottom">
												<p>
                                                    <asp:Image ID="Image2" runat="server" Height="500px" 
                                                        ImageUrl="~/images/education5.png" Width="200px" />
                                                </p>
                                            </TD>
										</TR>
									</TABLE>
								</TD>
								<TD vAlign="top" align="left">
									<TABLE id="Table3" style="FONT-SIZE: 12px; COLOR: black; FONT-FAMILY: Verdana" cellSpacing="2"
										cellPadding="3" border="0">
										<TR>
											<TD class="style5">Register No</TD>
											<TD class="style4"><asp:textbox id="TextBox_Reg" runat="server" CssClass="txtBox"></asp:textbox></TD>
											<TD>
												<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" 
                                                    ErrorMessage="Regno?" ControlToValidate="TextBox_Reg" ForeColor="#FF3300" 
                                                    ToolTip="Regno?" ValidationGroup="a"></asp:RequiredFieldValidator></TD>
										</TR>
									    <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                                <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
                                                    Text="Search" ValidationGroup="a" />
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                Name</td>
                                            <td align="left" class="style4">
                                                <asp:TextBox ID="txtName" runat="server" CssClass="txtBox"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="txtName" ErrorMessage="Name?" ForeColor="#FF3300" 
                                                    ToolTip="Regno?" ValidationGroup="attributes"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                Course</td>
                                            <td align="left" class="style4">
                                                <asp:Label ID="lblCourse" runat="server"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Sem</td>
                                            <td align="left" class="style4">
                                                <asp:Label ID="lblSem" runat="server"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                Hrs</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListHrs" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>&gt;4</asp:ListItem>
                                                    <asp:ListItem>4</asp:ListItem>
                                                    <asp:ListItem>3</asp:ListItem>
                                                    <asp:ListItem>2</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                                    ControlToValidate="DropDownListHrs" ErrorMessage="Hrs?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="Hrs?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Regular</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListRegular" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Regular</asp:ListItem>
                                                    <asp:ListItem>Irregular</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                                    ControlToValidate="DropDownListRegular" ErrorMessage="Regular?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="Regular?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Interaction</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListInteraction" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                     <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator10" runat="server" 
                                                    ControlToValidate="DropDownListInteraction" ErrorMessage="Interaction?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="DropDownListInteraction" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Time Management</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListTimeMgt" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                     <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator11" runat="server" 
                                                    ControlToValidate="DropDownListTimeMgt" ErrorMessage="Time Management?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="DropDownListTimeMgt" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                Grasping Ability</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListGraspingAbility" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator13" runat="server" 
                                                    ControlToValidate="DropDownListGraspingAbility" ErrorMessage="Grasping Ability?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="Grasping Ability?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                EXActivities</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListExActivities" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Best</asp:ListItem>
                                                    <asp:ListItem>Better</asp:ListItem>
                                                    <asp:ListItem>Good</asp:ListItem>
                                                    <asp:ListItem>Poor</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator14" runat="server" 
                                                    ControlToValidate="DropDownListExActivities" ErrorMessage="Ex Activities?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="Ex Activities?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                PrevSemResults</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListPrevResults" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem Value="89%-100%">S</asp:ListItem>
                                                    <asp:ListItem Value="74%-89%">A</asp:ListItem>
                                                    <asp:ListItem Value="59%-74%">B</asp:ListItem>
                                                    <asp:ListItem Value="49%-59%">C</asp:ListItem>
                                                    <asp:ListItem Value="44%-49%">D</asp:ListItem>
                                                    <asp:ListItem Value="40%-44%">E</asp:ListItem>
                                                    <asp:ListItem Value="&lt;40%">F</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator17" runat="server" 
                                                    ControlToValidate="DropDownListPrevResults" ErrorMessage="Previous Results?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="Previous Results?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                SSLC</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListSSLC" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                   <asp:ListItem Value="85%-100%">Distinction</asp:ListItem>
                                                    <asp:ListItem Value="60%-85%">FirstClass</asp:ListItem>
                                                    <asp:ListItem Value="45%-60%">SecondClass</asp:ListItem>
                                                    <asp:ListItem Value="35%-45%">ThirdClass</asp:ListItem>
                                                    <asp:ListItem Value="&lt;35%">Fail</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator18" runat="server" 
                                                    ControlToValidate="DropDownListSSLC" ErrorMessage="SSLC?" 
                                                    ForeColor="#FF3300" Operator="NotEqual" ToolTip="SSLC?" 
                                                    ValidationGroup="attributes" ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                PUC</td>
                                            <td align="left" class="style4">
                                                <asp:DropDownList ID="DropDownListPUC" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem Value="85%-100%">Distinction</asp:ListItem>
                                                    <asp:ListItem Value="60%-85%">FirstClass</asp:ListItem>
                                                    <asp:ListItem Value="45%-60%">SecondClass</asp:ListItem>
                                                    <asp:ListItem Value="35%-45%">ThirdClass</asp:ListItem>
                                                    <asp:ListItem Value="&lt;35%">Fail</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator19" runat="server" 
                                                    ControlToValidate="DropDownListPUC" ErrorMessage="PUC?" ForeColor="#FF3300" 
                                                    Operator="NotEqual" ToolTip="PUC?" ValidationGroup="attributes" 
                                                    ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style7">
                                                IHS</td>
                                            <td align="left" class="style8">
                                                <asp:DropDownList ID="DropDownListIHS" runat="server">
                                                    <asp:ListItem>Select</asp:ListItem>
                                                    <asp:ListItem>Yes</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="style9">
                                                <asp:CompareValidator ID="CompareValidator26" runat="server" 
                                                    ControlToValidate="DropDownListIHS" ErrorMessage="IHS?" ForeColor="#FF3300" 
                                                    Operator="NotEqual" ToolTip="IHS?" ValidationGroup="attributes" 
                                                    ValueToCompare="Select"></asp:CompareValidator>
                                            </td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                                <asp:Button ID="btnCheck" runat="server" Height="50px" onclick="btnCheck_Click" 
                                                    Text="Result Prediction" Enabled="False" />
                                                &nbsp;&nbsp;&nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									    <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td align="left" class="style4">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
									</TABLE>
								</TD>
							</TR>
						</TABLE>

    <br />


    <asp:Panel ID="Panel1" runat="server" Visible="False">
    <h2><span>TRAINING</span> DATASET</h2>
     <table style="width: 98%;" style="BORDER-RIGHT: dimgray 1px solid; BORDER-TOP: dimgray 1px solid; BORDER-LEFT: dimgray 1px solid; WIDTH: 600px; BORDER-BOTTOM: dimgray 1px solid; HEIGHT: 188px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" width="418" bgColor="#0" border="0">
        <tr>
            <td valign="top">
                <asp:Label ID="lblDataset" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Table ID="tableDataset" runat="server">
                </asp:Table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </asp:Panel>

    <br />
   
      <asp:Panel ID="Panel2" runat="server" Visible="False">
        <h2>RESULT PREDICTION</h2>
          <table style="width: 35%;" style="BORDER-RIGHT: dimgray 1px solid; BORDER-TOP: dimgray 1px solid; BORDER-LEFT: dimgray 1px solid; WIDTH: 400px; BORDER-BOTTOM: dimgray 1px solid; HEIGHT: 188px; BACKGROUND-COLOR: white"
							cellSpacing="1" cellPadding="1" width="418" bgColor="#0" border="0">
              <tr>
                  <td>
                      <b>Student Name</b></td>
                  <td>
                      <asp:Label ID="lblName" runat="server"></asp:Label>
                  </td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td>
                      <b>Course Name</b></td>
                  <td>
                      <asp:Label ID="lblCName" runat="server"></asp:Label>
                  </td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td>
                      <b>Result Prediction</b></td>
                  <td>
                      <asp:Label ID="lblOutput" runat="server"></asp:Label>
                  </td>
                  <td>
                      &nbsp;</td>
              </tr>
          </table>
      </asp:Panel>


   <br />
   </div>
   </asp:Panel>


</asp:Content>
