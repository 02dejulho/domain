#pragma checksum "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9407e71328194690a6732038a0dae59d1e2de00f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamento_Listar), @"mvc.1.0.view", @"/Views/Agendamento/Listar.cshtml")]
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
#line 1 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\_ViewImports.cshtml"
using PI_lucianasilva_Atv4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\_ViewImports.cshtml"
using PI_lucianasilva_Atv4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9407e71328194690a6732038a0dae59d1e2de00f", @"/Views/Agendamento/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be67e1a641d8665cfe8d78ca35d556b4eb25e5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamento_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<agendamentos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
  
ViewData["Title"] = "Lista de Agendamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
<h3>
    Aqui está a lista de agendamentos:

</h3>

<table width=""100%"" border=""1""> 

    <tr>
        <th style=""text-align:center"" width=""300px"">Cliente:</th>
        <th style=""text-align:center"" width=""300px"">Nome:</th>
        <th style=""text-align:center"" width=""300px"">Telefone:</th>
        <th style=""text-align:center"" width=""300px"">Data:</th>
        <th style=""text-align:center"" width=""300px"">Área:</th>
        <th style=""text-align:center"" width=""300px"">Proc. Desejado:</th>
        <th style=""text-align:center"" width=""300px"">Observações:</th> 
        <th style=""text-align:center"" width=""300px"">Ação:</th>          
    </tr>


");
#nullable restore
#line 26 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
     foreach(agendamentos ag in Model) //dados serao apresentados na tabela. Cada dado 'da' guarda uma informação - variaveis declaradas na classe DadosAgendamento
    {  


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>  \r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 30 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.clienteag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                                                      \r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 31 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 32 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 33 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.data.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/ ");
#nullable restore
#line 33 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                                 Write(ag.data.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/ ");
#nullable restore
#line 33 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                                                 Write(ag.data.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 34 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 35 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.procedimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"text-align:center\" width=\"300px\">");
#nullable restore
#line 36 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
                                                   Write(ag.observacoes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1618, "\"", 1661, 2);
            WriteAttributeValue("", 1625, "/Agendamento/Editar?idBusca=", 1625, 28, true);
#nullable restore
#line 40 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
WriteAttributeValue("", 1653, ag.idAg, 1653, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> | \r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1696, "\"", 1741, 2);
            WriteAttributeValue("", 1703, "/Agendamento/Deletar?idDelete=", 1703, 30, true);
#nullable restore
#line 41 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
WriteAttributeValue("", 1733, ag.idAg, 1733, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n\r\n\r\n        </tr> \r\n");
#nullable restore
#line 46 "C:\Users\acjhe\OneDrive\Documentos\SENAC\PI\PI-lucianasilva-Atv4\Views\Agendamento\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<agendamentos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
