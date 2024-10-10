using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Domain.Interfaces.Messagens
{
    /// <summary>
    /// Interface para definir os métodos que irão gravar conteudo
    /// no servidor da mensageria
    /// </summary>
    public interface IMessageProducer
    {
        /// <summary>
        /// Método para enviarmos uma mensagem na fila do servidor da mensageria
        /// </summary>
        /// <param name="message"></param>
        void Send(string message);
    }
}
