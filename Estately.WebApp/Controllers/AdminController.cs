using Estately.Core.Entities;
using Estately.Core.Interfaces;
using Estately.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;

namespace Estately.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }


        // ============================================
        // DASHBOARD
        // ============================================
        public async Task<IActionResult> Dashboard()
        {
            var stats = new
            {
                TotalUsers = await _userManager.Users.CountAsync(),
                TotalProperties = (await _unitOfWork.PropertyRepository.ReadAllAsync()).Count(),
                TotalAppointments = (await _unitOfWork.AppointmentRepository.ReadAllAsync()).Count(),
                TotalEmployees = (await _unitOfWork.EmployeeRepository.ReadAllAsync()).Count(),
                TotalClients = (await _unitOfWork.ClientProfileRepository.ReadAllAsync()).Count(),
                TotalBranches = (await _unitOfWork.BranchRepository.ReadAllAsync()).Count()
            };

            ViewBag.Stats = stats;
            return View();
        }
    }
}