using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Core
{
    public class Bootstrapper
    {
        #region Properties
        ILogProvider logProvider;
        IConfigProvider configProvider;
        IDomainProvider domainProvider;
        INavigatorProvider viewNavProvider;
        #endregion

        /// <summary>
        /// Construct a boot strapper for Light framework. 
        /// </summary>
        /// <param name="Args">Application init args</param>
        public Bootstrapper(string[] Args)
        {
            
        }

        #region Init Implementations
        /// <summary>
        /// Init log provider
        /// </summary>
        /// <param name="provider">ILogProvider</param>
        private void InitLog(ILogProvider provider)
        {
        }

        /// <summary>
        /// Init configuration provider
        /// </summary>
        /// <param name="provider">IConfigProvider</param>
        private void InitConfigurations(IConfigProvider provider)
        {
        }

        /// <summary>
        /// Init domain provider
        /// </summary>
        /// <param name="provider">IDomainProvider</param>
        private void InitDomains(IDomainProvider provider)
        {
        }

        /// <summary>
        /// Init view navigator provider
        /// </summary>
        /// <param name="viewProvider">IViewNavigatorProvider</param>
        private void InitViewNavigator(INavigatorProvider viewProvider)
        {
        }
        #endregion
    }
}
