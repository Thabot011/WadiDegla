using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WD.Data.Model;
using WD.Service.SaleFromService;
using WD.Web.DTO;

namespace WD.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesFormController : ControllerBase
    {
        private readonly ISaleFromService _saleFormService;
        private readonly IMapper _mapper;

        public SalesFormController(ISaleFromService saleFormService, IMapper mapper)
        {
            _saleFormService = saleFormService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> AddSaleFrom([FromBody]SalesFormDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SaleForm salesLeadsForm = _mapper.Map<SaleForm>(model);
                    var result =  await _saleFormService.InsertSaleForm(salesLeadsForm);
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
        public async Task<IActionResult> UpdateSaleFrom([FromBody]SalesFormDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SaleForm salesLeadsForm = _mapper.Map<SaleForm>(model);
                    await _saleFormService.UpdateSaleForm(salesLeadsForm);

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
        public async Task<IActionResult> DeleteSalesLeads(int SalesFormId)
        {
            int result = 0;

            if (SalesFormId == 0)
            {
                return BadRequest();
            }

            try
            {
                result = await _saleFormService.DeleteSaleForm(SalesFormId);
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
                var posts = await _saleFormService.GetSaleForms();
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