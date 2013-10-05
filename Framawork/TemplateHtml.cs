using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framawork
{
    class TemplateHtml
    {
      public static string mountEmail(){

          return @"
                    <!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Strict//EN'
                    'http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd'>
                    <html>
                      <head>
                    <meta http-equiv='Content-Type' content='text/html;charset=ISO-8859-1' />
                      </head>
                    <table border = '1' width='50%'>
                    	<tr>
                    		<td  width='10%'>
                    			<h2>LOGO</h2>
                    		</td>	
                    		<td  width='90%'>
                    			<h2>Email Informativo</h2>
                    		</td>
                    	</tr>
                    	<tr>
                    		<td colspan='2'>Olá {NOME_EMPRESA} o(a) {NOME_PESSOA} solicita um orçamento de receita </td>
                    	</tr>
                    	<tr>
                    		<td colspan='2' style='text-align:center;'>Dados</td>
                    	</tr>	
                    	<tr>
                    		<td>Email:</td>
                    		<td>{EMAIL}</td>
                    	</tr>
                    	<tr>
                    		<td>Telefone</td>
                    		<td>{TELEFONE}</td>
                    	</tr>
                    	<tr>
                    		<td colspan='2'><img src ='{IMAGEM}'></td>
                    	</tr>
                    	<tr>
                    		<td colspan='2' style='font-size:10px;'>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu porta magna, porta scelerisque mauris. In purus orci, posuere sit amet sapien ut, consequat venenatis lorem. Vestibulum aliquet turpis et sodales tempus. Praesent fringilla pellentesque augue, in suscipit magna semper venenatis.</td>
                    	</tr>	
                    </table>
                    <style>
                    table {
                        border-collapse: collapse;
                        font-family: arial;
                        margin: 0 auto;
                    }
                    table td {
                        padding: 5px;
                    }
                    h2 {
                        text-align: center;
                    }
                    </style>";
      }

    }
}
