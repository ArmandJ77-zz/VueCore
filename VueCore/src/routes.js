import HomeDashboard from './components/dashboards/HomeDashboard.vue'
import ClientDashboard from './components/dashboards/ClientDashboard.vue'

export default[
  {
    path : '/',
    component : HomeDashboard
  }, {
    path : '/client',
    component : ClientDashboard
  }
]
