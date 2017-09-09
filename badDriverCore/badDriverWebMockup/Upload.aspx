<script runat="server">

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs)

    End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
      <title></title>
  </head>
  <body>
      <div>
      <div id="content">
              <form id="form2" runat="server">
                  <div>
                      <br />
                      <asp:FileUpload ID="FileUpload" runat="server"  AllowMultiple="True" />
                      <br />
                                          <asp:Label runat="server" id="StatusLabel" text=""  ForeColor="Red" />
                      <br />
                      <asp:Button ID="btnUpload" OnClientClick="return confirm('Upload Concluido com Sucesso');" runat="server" Text="Carregar Fotos" />                    
                      <br />
                      <br />
                      <br />
                      <br />
                      </div>
              </form>
                                                 <br class="clearfix" />
                                 </div>
      </div>
  </body>
  </html>