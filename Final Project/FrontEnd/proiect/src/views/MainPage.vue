<template>
  <NavBar name="Animal Glimpse" />
</template>

<script>

import {defineComponent} from "vue";
import NavBar from "@/components/NavBar.vue";

export default defineComponent({
  components: {NavBar},
  setup(){
    localStorage.setItem('OtherToken', null);
  }
})
</script>

<style scoped>

</style>
