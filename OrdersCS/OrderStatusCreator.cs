﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace TradingEngineServer.Orders
{
    public sealed class OrderStatusCreator
    {
        public static CancelOrderStatus GenerateCancelOrderStatus(CancelOrder cancelOrder)
        {
            return new CancelOrderStatus();
        }

        public static NewOrderStatus GenerateNewOrderStatus(Order order)
        {
            return new NewOrderStatus();
        }

        public static ModifyOrderStatus GenerateModifyOrderStatus(ModifyOrder modifyOrder)
        {
            return new ModifyOrderStatus();
        }

    }
}
