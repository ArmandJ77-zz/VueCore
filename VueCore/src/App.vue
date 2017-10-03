<template>
  <v-app>
      <routerComponent></routerComponent>
      <router-view></router-view>
  </v-app>
</template>

<script>
import routerComponent from './components/router/routerComponent.vue';
export default {
  components: {
    'routerComponent': routerComponent
  },
  data() {
    return {
    }
  }
}
</script>

<style lang="stylus">
  @import './stylus/theme'
</style>
