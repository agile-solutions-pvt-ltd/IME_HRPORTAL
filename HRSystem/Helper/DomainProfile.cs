using AutoMapper;
using HRSystem.Models;

namespace HRSystem.Helper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<LeaveRequestViewModel, LeaveRequestCard.leaverequestcard>();
            CreateMap<PostedLeaveRequestCard.postedleaverequestcard, PostedLeaveRequestViewModel>();
            CreateMap<PostedLeaveRequestViewModel, PostedLeaveRequestCard.postedleaverequestcard>();

            CreateMap<TravelOrderViewModel, TravelOrderCard.travelordercard>();
            CreateMap<PostedTravelOrderCard.postedtravelordercard, PostedTravelOrderViewModel>();
            CreateMap<PostedTravelOrderViewModel, PostedTravelOrderCard.postedtravelordercard>();

            CreateMap<SalaryAdvanceViewModel, SalaryAdvanceRequest.salaryadvancerequest>();
            CreateMap<PostedSalaryAdvance.postedsalaryadvancecard, PostedSalaryAdvanceViewModel>();
            CreateMap<PostedSalaryAdvanceViewModel, PostedSalaryAdvance.postedsalaryadvancecard>();

            CreateMap<TravelVoucherViewModel, TravelVoucher.travelvoucher>();
            CreateMap<PostedTravelVoucherCard.postedtravelvouchercard, PostedTravelVoucherViewModel>();
            CreateMap<PostedTravelVoucherViewModel, PostedTravelVoucherCard.postedtravelvouchercard>();
        }
    }
}
