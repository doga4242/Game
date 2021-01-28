using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IKampanya
    {

        void AddKampanya(IKampanya kampanya);

        void DeleteKampanya(IKampanya kampanya);

        void UpdateNewKampanya(IKampanya kampanya);

    }
}
