using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    internal class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, long price, uint quantity, bool isBuySide)
        {

        }

        //Fields
        private readonly IOrderCore _orderCore;
    }
}
