using DevSpot.Models;
using DevSpot.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DevSpot.Controllers
{
    public class JobPostingController : Controller
    {

        private readonly IRepository<JobPosting> _repository;
        private readonly UserManager<IdentityUser> _userManager;

        public JobPostingController(IRepository<JobPosting> repository, 
            UserManager<IdentityUser> userManager)
        {
            _repository = repository; 
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var jobPostings = await _repository.GetAllAsync();
            return View(jobPostings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(JobPosting jobPosting)
        {

            // load user here and id too
            //ModelState.Remove("User");
            //ModelState.Remove("UserId");



            if (ModelState.IsValid)
            {
                jobPosting.UserId = _userManager.GetUserId(User);
                await _repository.AddAsync(jobPosting);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}