/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceTypeFamiliesResponseUnmarshaller
    {
        public static DescribeInstanceTypeFamiliesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceTypeFamiliesResponse describeInstanceTypeFamiliesResponse = new DescribeInstanceTypeFamiliesResponse();

			describeInstanceTypeFamiliesResponse.HttpResponse = context.HttpResponse;
			describeInstanceTypeFamiliesResponse.RequestId = context.StringValue("DescribeInstanceTypeFamilies.RequestId");

			List<DescribeInstanceTypeFamiliesResponse.InstanceTypeFamily> instanceTypeFamilies = new List<DescribeInstanceTypeFamiliesResponse.InstanceTypeFamily>();
			for (int i = 0; i < context.Length("DescribeInstanceTypeFamilies.InstanceTypeFamilies.Length"); i++) {
				DescribeInstanceTypeFamiliesResponse.InstanceTypeFamily instanceTypeFamily = new DescribeInstanceTypeFamiliesResponse.InstanceTypeFamily();
				instanceTypeFamily.InstanceTypeFamilyId = context.StringValue("DescribeInstanceTypeFamilies.InstanceTypeFamilies["+ i +"].InstanceTypeFamilyId");
				instanceTypeFamily.Generation = context.StringValue("DescribeInstanceTypeFamilies.InstanceTypeFamilies["+ i +"].Generation");

				instanceTypeFamilies.Add(instanceTypeFamily);
			}
			describeInstanceTypeFamiliesResponse.InstanceTypeFamilies = instanceTypeFamilies;
        
			return describeInstanceTypeFamiliesResponse;
        }
    }
}