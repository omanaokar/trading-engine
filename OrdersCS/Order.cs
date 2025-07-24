using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    internal class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, long price, uint quantity, bool isBuySide)
        {
            // PROPERTIES
            Price = price;
            IsBuySide = isBuySide;
            InitialQuantity = quantity;
            CurrentQuantity = quantity;

            // FIELD
            _orderCore = orderCore;
        }

        public long Price { get; private set; }
        public uint  InitialQuantity { get; private set; }
        public uint CurrentQuantity { get; private set; }
        public bool IsBuySide { get; private set; } 

        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // METHODS
        public void increaseQuantity(uint quantityDelta)
        {
            CurrentQuantity += quantityDelta;
        }

        public void decreaseQuantity(uint quantityDelta)
        {
            if (quantityDelta > CurrentQuantity)
                throw new InvalidOperationException($"Quantity Delta > Current Quantity for OrderId={OrderId}");
            CurrentQuantity -= quantityDelta;
        }

        //Fields
        private readonly IOrderCore _orderCore;
    }
}
