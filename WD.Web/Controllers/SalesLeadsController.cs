using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WD.Data.Model;
using WD.Service.SalesLeadsFormService;
using WD.Web.DTO;

namespace WD.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesLeadsController : ControllerBase
    {
        private readonly ISalesLeadsFormService _salesLeadsFormService;
        private readonly IMapper _mapper;

        public SalesLeadsController(ISalesLeadsFormService salesLeadsFormService, IMapper mapper)
        {
            _salesLeadsFormService = salesLeadsFormService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> AddSalesLeads([FromBody]SalesLeadsFormDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    salesLeadsForm salesLeadsForm = _mapper.Map<salesLeadsForm>(model);
                    var result =  await _salesLeadsFormService.InsertsalesLeadsForm(salesLeadsForm);
                    if (result > 0)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateSalesLeads([FromBody]SalesLeadsFormDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    salesLeadsForm salesLeadsForm = _mapper.Map<salesLeadsForm>(model);
                    await _salesLeadsFormService.UpdatesalesLeadsForm(salesLeadsForm);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }




        [HttpDelete]
        public async Task<IActionResult> DeleteSalesLeads(int SalesLeadsId)
        {
            int result = 0;

            if (SalesLeadsId == 0)
            {
                return BadRequest();
            }

            try
            {
                result = await _salesLeadsFormService.DeletesalesLeadsForm(SalesLeadsId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetSalesLeads()
        {
            try
            {
                var posts = await _salesLeadsFormService.GetSalesLeadsForms();
                if (posts == null)
                {
                    return NotFound();
                }

                return Ok(posts);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}