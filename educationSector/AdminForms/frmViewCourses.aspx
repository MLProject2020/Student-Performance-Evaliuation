<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMasterpage.Master" AutoEventWireup="true" CodeBehind="frmViewCourses.aspx.cs" Inherits="educationSector.frmViewCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:Panel ID="panelViewCourse" runat="server">
   <div class="article">
      <h2><span>VIEW </span> COURSES</h2>


   		<TABLE id="Table2" style="border-color: #666666; BORDER-TOP-WIDTH: 1px; FONT-WEIGHT: normal; BORDER-LEFT-WIDTH: 1px; FONT-SIZE: 12px; BORDER-BOTTOM-WIDTH: 1px; WIDTH: 483px; COLOR: #000000; FONT-FAMILY: Verdana; HEIGHT: auto; BORDER-RIGHT-WIDTH: 1px; "
							cellSpacing="0" cellPadding="0" width="483" border="0">
							<TR>
								<TD style="BORDER-RIGHT: #666666 1px solid; BORDER-BOTTOM: #666666 1px solid; BORDER-TOP: #666666 1px solid;BORDER-LEFT: #666666 1px solid;FONT-WEIGHT: bold; FONT-SIZE: 12px; HEIGHT: 10px; COLOR: white; BACKGROUND-COLOR: #FF9933; border-color: #666666;"
									vAlign="middle" align="left" colSpan="2" >
									<asp:Label id="Label1" runat="server">View Courses :</asp:Label></TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #666666 1px solid; BORDER-TOP: #666666 1px solid; BORDER-LEFT: #666666 1px solid; WIDTH: 170px; BORDER-BOTTOM: #666666 1px solid; HEIGHT: 282px; border-color: #666666;"
									vAlign="middle" align="center"><IMG style="WIDTH: 232px; HEIGHT: 293px" height="293" src="../Images/course_delivery.gif"
										width="232"></TD>
								<TD vAlign="middle" align="left" colSpan="1" rowSpan="2" 
                                    style="BORDER-TOP-WIDTH: 1px; BORDER-RIGHT: #666666 1px solid; BORDER-LEFT: #666666 1px solid; BORDER-TOP-COLOR: #666666; BORDER-BOTTOM: #666666 1px solid" 
                                    class="style1">
									<TABLE id="Table3" style="BORDER-TOP: #666666 2px double; WIDTH: 202px; BORDER-BOTTOM: #666666 2px groove; HEIGHT: 175px; border-top-color: #666666; border-bottom-color: #666666;"
										cellSpacing="3" cellPadding="1" width="202" border="0">
										<TR>
											<TD valign="top" style="BORDER-TOP-WIDTH: 1px; BORDER-RIGHT: #666666 1px solid; BORDER-LEFT-WIDTH: 1px; border-bottom-width: 1px; border-color: #666666;"
												align="center">
												<asp:DataGrid id="DataGridView" runat="server" Height="40px" Width="394px" BorderColor="#666600"
													BorderWidth="1px" CellPadding="0" ForeColor="Black" BackColor="Beige" Font-Size="Smaller"
													AutoGenerateColumns="False" PageSize="15" AllowPaging="True">
													<EditItemStyle Font-Size="12px" HorizontalAlign="Center" VerticalAlign="Middle"></EditItemStyle>
													<AlternatingItemStyle Font-Size="12px" HorizontalAlign="Center" VerticalAlign="Middle"></AlternatingItemStyle>
													<ItemStyle Font-Size="12px" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
													<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
														ForeColor="White" VerticalAlign="Middle" BackColor="#FF9933"></HeaderStyle>
													<Columns>
														<asp:HyperLinkColumn DataNavigateUrlField="cname" DataNavigateUrlFormatString="frmAddCourse.aspx?cname={0}"
															DataTextField="cname" HeaderText="Course" FooterText="s" NavigateUrl="frmAddCourse.aspx">
															<ItemStyle Font-Size="12px" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
														</asp:HyperLinkColumn>
														<%--<asp:HyperLinkColumn Text="View" DataNavigateUrlField="cname" DataNavigateUrlFormatString="frmViewSubjects.aspx?cname={0}"
															HeaderText="Subjects" NavigateUrl="frmAddSubjects.aspx">
															<ItemStyle Font-Size="12px" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
														</asp:HyperLinkColumn>
														<asp:HyperLinkColumn Text="Add" DataNavigateUrlField="cname" DataNavigateUrlFormatString="frmAddSubjects.aspx?cname={0}"
															HeaderText="Subjects" NavigateUrl="frmAddSubjects.aspx"></asp:HyperLinkColumn>--%>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:DataGrid></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="BORDER-RIGHT: #666666 1px solid; BORDER-TOP: #666666 1px solid; BORDER-LEFT: #666666 1px solid; WIDTH: 170px; BORDER-BOTTOM: #666666 1px solid"
									vAlign="top" align="right">
									<asp:Button id="Button_Add" runat="server" CssClass="Button_Click" Text="Add New Course" onclick="Button_Add_Click"></asp:Button></TD>
								<TD vAlign="middle" align="center"></TD>
							</TR>
						</TABLE>

     <br />
     </div>
   </asp:Panel>

</asp:Content>
