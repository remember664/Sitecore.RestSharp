﻿/*
   Copyright 2013 Sergey Oleynik
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace Sitecore.RestSharp.Parameters
{
  using System.Collections.Generic;
  using System.Linq;

  using global::RestSharp;

  public class MultiUrlParameterReplacer : MultiParameterReplacer
  {
    protected override IEnumerable<Parameter> GetParameters(IRestRequest request)
    {
      return request.Parameters.Where(i => i.Type == ParameterType.UrlSegment);
    }
  }
}