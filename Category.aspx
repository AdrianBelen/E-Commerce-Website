<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="Category.aspx.vb" Inherits="ECommerceCISProject.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="second-page-container">
       <div class="container">
            <div class="row">
				        		<h2>
                            <asp:label id="lblCategoryName" runat="server" text ="Label"></asp:label>
						</h2>
						<asp:SqlDataSource ID="SqlDSSubCategory" runat="server" 
		                    ConnectionString="<%$ ConnectionStrings:ConnectionStringECommerceProject %>" 
		                    SelectCommand=""></asp:SqlDataSource>
	                    <asp:Repeater ID="rpSubCategory" runat="server" DataSourceID="SqlDSSubCategory">
		                    <ItemTemplate>
			                    <div class="panel panel-default">
				                    <div class="panel-heading">
					                    <h4 class="panel-title"><a href="#"><%# Trim(Eval("CategoryName")) %></a></h4>
				                    </div>
			                    </div>                 
		                    </ItemTemplate>
                        </asp:Repeater>
                                </div>
							</div>
						</div><!--/category-productsr-->
					
						
					
				<div class="col-sm-9 padding-right">
					<div class="features_items"><!--features_items-->
						<h2 class="title text-center">Features Items</h2>
                        <asp:SqlDataSource ID="SqlDSProductList" runat="server" 
		                    ConnectionString="<%$ ConnectionStrings:ConnectionStringECommerceProject %>" 
		                    SelectCommand=""></asp:SqlDataSource>
	                    <asp:Repeater ID="rptProductList" runat="server" DataSourceID="SqlDSProductList" Visible="True">
		                    <ItemTemplate>
			                    <div class="col-sm-4">
				                    <div class="product-image-wrapper">
				                    <div class="single-products">
					                    <div class="productinfo text-center">
						                    <img src="images/product-details/<%# Trim(Eval("ProductNo")) %>.jpg" width="100" alt="" />
						                    <h2>$<%# Eval("Price") %></h2>
						                    <p><a href="ProductDetail.aspx?ProductNo=<%# Eval("ID") %>"><%# Eval("ProductName") %></a></p>
						                    <a href="#" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Add to cart</a>
					                    </div>
				                    </div>
			                    </div>
			                    </div>			                           
		                    </ItemTemplate>
	                    </asp:Repeater>
						</div>
						
						<ul class="pagination">
							<li class="active"><a href="">1</a></li>
							<li><a href="">2</a></li>
							<li><a href="">3</a></li>
							<li><a href="">&raquo;</a></li>
						</ul>
					</div><!--features_items-->
				</div>
						</div>
					</div>
</asp:Content>
