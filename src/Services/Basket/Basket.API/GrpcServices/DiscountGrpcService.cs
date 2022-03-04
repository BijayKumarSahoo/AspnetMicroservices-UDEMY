using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    // Encapsulate the Client Grpc Service Classes
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService;
        }


        public async Task<CouponModel> GetDiscount(string productName)
        {
            // Call to the Grpc Service asynchronously
            var discountRequest = new GetDiscountRequest { ProductName = productName };

            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }
    }
}
