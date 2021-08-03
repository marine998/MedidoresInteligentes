﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IUsuarioDAL
    {
        List<usuario> ObtenerUsuario();
        usuario Obtener(int id);

        void AgregarUsuario(usuario usuario);
        void EliminarUsuario(int id);
    }
}
