using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_demo.Areas.test.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_demo.Areas.test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 获取所有学生
        /// </summary>
        /// <returns></returns>
        // GET: api/<ValuesController>
        [HttpGet]
        public List<Student> Get()
        {
            return DataHelper.GetStudent();
        }

        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = new Student();
            for (int i = 0; i < DataHelper.ListStudent.Count; i++)
            {
                if (DataHelper.ListStudent[i].ID == i)
                {
                    student = DataHelper.ListStudent[i];
                    break;
                }
            }
            return student;
        }

        /// <summary>
        /// 新增学生
        /// </summary>
        /// <param name="value"></param>
        // POST api/<ValuesController>
        [HttpPost]
        public List<Student> Post(Student entity)
        {
            DataHelper.ListStudent.Add(entity);
            return DataHelper.ListStudent;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public List<Student> Put(Student entity)
        {
            for (int i = 0; i < DataHelper.ListStudent.Count; i++)
            {
                if (DataHelper.ListStudent[i].ID == entity.ID)
                {
                    DataHelper.ListStudent[i].Name = entity.Name;
                    DataHelper.ListStudent[i].Age = entity.Age;
                    break;
                }
            }
            return DataHelper.ListStudent;
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public List<Student> Delete(int id)
        {
            for (int i = 0; i < DataHelper.ListStudent.Count; i++)
            {
                if (DataHelper.ListStudent[i].ID == id)
                {
                    DataHelper.ListStudent.Remove(DataHelper.ListStudent[i]);
                    break;
                }
            }
            return DataHelper.ListStudent;
        }
    }
}
