<template>
  <div>
    <v-navigation-drawer permanent floating light>
      <ul>
        <li v-for="item in items" :key="item.title">
          <router-link v-bind:to="item.link">
            <v-list-tile>
              <v-list-tile-action>
                <v-icon>{{ item.icon }}</v-icon>
              </v-list-tile-action>
              <v-list-tile-content>
                <v-list-tile-title>{{ item.title }}</v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile>
          </router-link>
        </li>
      </ul>
    </v-navigation-drawer>
    <v-toolbar class="theme--dark blue" darken fixed>
      <v-toolbar-title>Demo 1</v-toolbar-title>
    </v-toolbar>
    <main>
    </main>
  </div>
</template>

<script>
export default {
  data() {
    return {
      drawer: null,
      items: [
        { icon: 'dashboard', title: 'Dashboard', link: '/' },
        { icon: 'recent_actors', title: 'Client', link: '/client' },
      ],
      right: null
    }
  }
}
</script>

<style>
a {
  text-decoration: none;
}
ul {
  list-style: none;
  padding-left: 0px !important;
}
</style>
