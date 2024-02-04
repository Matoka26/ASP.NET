<template>
  <div>
    <h1>Login</h1>
    <form @submit.prevent="login">
      <div>
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email" required>
      </div>
      <div>
        <label for="password">Password:</label>
        <input type="password" id="password" v-model="password" required>
      </div>
      <button type="submit">Login</button>
    </form>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import {login as authServiceLogin} from "@/Helpers/Axios";
import router from "@/router";

export default defineComponent({
  name: 'LoginPage',
  setup() {
    const email = ref('');
    const password = ref('');

    const login = async () => {
      await authServiceLogin(email.value, password.value);
      console.log(email.value, password.value);
      var token = localStorage.getItem('MyToken');
      if(token){
        await router.push('/MainPage');
      }
    };
    return { email, password, login };
  },
});
</script>
