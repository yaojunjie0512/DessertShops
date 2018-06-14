﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///CustomerFactory 的摘要说明
/// </summary>
public class CustomerFactory
{
    private static List<Customer> customersList = new List<Customer>(){new Customer("101", "余先生", "cool", "男", new DateTime(1990 - 1 - 21), "绍兴文理学院", "18857518492", 10000M, "浙江省", "绍兴市"), new Customer("102", "Tom", "123", "男", new DateTime(2006 - 5 - 22), "绍兴文理学院", "13856569696", 10000M, "浙江省", "绍兴市")};
    

    //public static List<Customer> GetCustomersList()
    //{
        
    //    Customer c = new Customer("101","余先生","cool","男",new DateTime(1990-1-21),"绍兴文理学院","18857518492",10000M,"浙江省","绍兴市");
    //    customersList.Add(c);
    //    c = new Customer("102", "Tom", "123", "男", new DateTime(2006 - 5 - 22), "绍兴文理学院", "13856569696", 10000M, "浙江省", "绍兴市");
    //    customersList.Add(c);

    //    return customersList;
    //}
    public static Customer GetCustomerByUserId(string id)
    {
        Customer customer = new Customer();
        for (int i = 0; i < customersList.Count; i++)
        {
            if (customersList[i].UserId == id)
            {
                customer = customersList[i];
                break;
            }
        }
        return customer;
    }

    public static Customer GetCustomerByTelNo(string telNo,string pwd)
    {

        for (int i = 0; i < customersList.Count; i++)
        {
            if (customersList[i].TelNo == telNo && customersList[i].UserPwd == pwd)
            {
               return  customersList[i];
            }
        }
        return null;
    }
    public static bool HasCustomerByTelNo(string telNo)
    {
        for (int i = 0; i < customersList.Count; i++)
        {
            if (customersList[i].TelNo == telNo)
            {
               return true;
            }
        }
        return false;
    }
    public static Customer Recharge(string telNo,decimal num)
    {


        for (int i = 0; i < customersList.Count; i++)
        {
            if (customersList[i].TelNo == telNo)
            {
               customersList[i].Balance+=num;
               return customersList[i];
            }
        }
        return null;
    }

    public static Customer CustomerPay(string telNo, decimal num)
    {

        for (int i = 0; i < customersList.Count; i++)
        {
            if (customersList[i].TelNo == telNo)
            {
               customersList[i].Balance-=num;
               return customersList[i];
            }
        }
        return null;
    }

}