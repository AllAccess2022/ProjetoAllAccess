function setNomeUsuario()
            {
                    console.log("Chamou setNomeUsuario");
                var element = document.getElementById('NomeUsuario');
                if (element)
                {
                    var elementURL = element.getAttribute('href');
                        element.setAttribute('href', elementURL '&nomeUsuario=' + $("#NomeUsuario").val());
                }
            }