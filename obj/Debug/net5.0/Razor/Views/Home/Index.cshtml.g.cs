#pragma checksum "C:\Users\David\source\repos\JQueryPage\JQueryPage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "139c5957379f05aabf0c3ee6fe37aa5719fc4192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\David\source\repos\JQueryPage\JQueryPage\Views\_ViewImports.cshtml"
using JQueryPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\source\repos\JQueryPage\JQueryPage\Views\_ViewImports.cshtml"
using JQueryPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"139c5957379f05aabf0c3ee6fe37aa5719fc4192", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173570e8aa241b202c9d7b3f4492adaed38a1205", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "139c5957379f05aabf0c3ee6fe37aa5719fc41923307", async() => {
                WriteLiteral(@"
    <title>jQuery Ajax tutorial</title>
    <style>
        /* For jQuery Drink Test*/
        ul {
            padding: 0;
        }

            ul li {
                list-style-type: none;
                background: #EFEFEF;
                padding: 10px;
                margin-bottom: 10px;
            }

      
                ul li .edit {
                    display: none;
                }

                    ul li.edit .edit {
                        display: initial;
                    }

                    ul li.edit .noedit {
                        display: none;
                    }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "139c5957379f05aabf0c3ee6fe37aa5719fc41924923", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div>
            <h3>jQuery Ajax tutorial</h3>
            <br />
            <h6> Coffee Order</h6>
            <br />
            <ul id=""orders""></ul>
            <template id=""order-template"">
                <li data-id='{{id}}'>
                    <p>
                        <strong>Name:</strong>
                        <span class=""noedit name"">{{name}}</span>
                        <input class=""edit name"" value=""name"" />
                    <p>
                    <p>
                        <strong>Drink:</strong>
                        <span class=""noedit drink"">{{drink}}</span>
                        <input class=""edit drink"" value=""drink""/>
                    <p>
                        <button data-id='{{id}}' class='remove'>X</button>
                        <button class=""editOrder noedit"">Edit</button>
                        <button class=""saveEdit edit"">Save</button>
                        <button class=""cancelEdit edit"">Cancel</");
                WriteLiteral(@"button>
                </li>
            </template>

            <h4>Add a Coffee Order</h4>
            <p>Name : <input type=""text"" id=""name"" /></p>
            <p>Drink : <input type=""text"" id=""drink"" /></p>
            <button id=""add-order"">Add!</button>

        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.6.0.js""></script>
    <script src=""https://code.jquery.com/jquery-migrate-3.4.0.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/mustache.js/2.1.3/mustache.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>



<script type=""text/javascript"">
    $(document).ready(function () {
        $(function () {
            var $orders = $('#orders');
            var $name = $('#name');
            var $drink = $('#drink');

            var orderTemplate = $('#order-template').html();

            function AddOrder(order) {
                $orders.append(Mustache.render(orderTemplate, order));
            }

            $.ajax({
                type: 'GET',
                url: '/api/Customers/',
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (orders) {
                    //alert(JSON.stringify(orders));
                    $.each(orders, function (i, order) {
                        AddOrder(order);
                    });

                },
                error: function (e) {
                    alert(e.responseText);
                },
            });

            $('#add-order').on('click'");
            WriteLiteral(@", function () {
                var order = { name: $name.val(), drink: $drink.val() };
                $.ajax({
                    type: 'POST',
                    url: '/api/Customers/',
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    data: JSON.stringify(order),
                    success: function (newOrder) {
                        AddOrder(newOrder);
                    },
                    error: function (e) {
                        alert(e.responseText);
                    }
                });
            });

            $orders.delegate('.remove', 'click', function () {
                var $li = $(this).closest('li');

                $.ajax({
                    type: 'DELETE',
                    url: '/api/Customers/' + $(this).attr('data-id'),
                    success: function () {
                        $li.fadeOut(300, function () {
                            $(this).remove();");
            WriteLiteral(@"
                        });
                    },
                    error: function (e) {

                        e.responseText
                    },
                });
            });

            $orders.delegate('.editOrder', 'click', function () {
                var $li = $(this).closest('li');
                $li.find('input.name').val($li.find('span.name').html());
                $li.find('input.drink').val($li.find('span.drink').html());
                $li.addClass('edit');
            });

            $orders.delegate('.cancelEdit', 'click', function () {
                $(this).closest('li').removeClass('edit');
            });

            $orders.delegate('.saveEdit', 'click', function () {
                var $li = $(this).closest('li');
                var order = {
                    Id: $li.attr('data-id'),
                    name: $li.find('input.name').val(),
                    drink: $li.find('input.drink').val()
                };
                $.");
            WriteLiteral(@"ajax({
                    type: 'PUT',
                    url: '/api/Customers/' + $li.attr('data-id'),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    data:JSON.stringify(order),
                    success: function () {
                        $li.find('span.name').html(order.name);
                        $li.find('span.drink').html(order.drink);
                        $li.removeClass('edit');
                    },
                    error: function (e) {
                        alert(e.responseText);
                    },
                }).done(function () {
                    //alert(""Update done."");
                    //$li.removeClass('edit');
                });

            });

        });

    });

   
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
