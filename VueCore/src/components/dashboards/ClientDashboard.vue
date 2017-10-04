<template>
  <div>
    <v-container fluid fill-height>
      <v-layout>
        <v-flex offset-lg3 offset-sm4>
          <add-component></add-component>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
import AddComponent from '../clients/AddComponent';

export default {
  components: {
    'add-component': AddComponent
  },
}
</script>

<style>
</style>
