<template>
  <div>
    <h1>Login</h1>
    <form @submit.prevent="signUp">
      <div>
        <label for="firstName">FirstName:</label>
        <input id="firstName" v-model="firstName" required>
      </div>
      <div>
        <label for="lastName">LastName:</label>
        <input id="lastName" v-model="lastName" required>
      </div>
      <div>
        <label for="phoneNumber">PhoneNumber:</label>
        <input id="phoneNumber" v-model="phoneNumber" required>
      </div>
      <div>
        <label for="userName">Username:</label>
        <input id="userName" v-model="userName" required>
      </div>
      <div>
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email" required>
      </div>
      <div>
        <label for="password">Password:</label>
        <input type="password" id="password" v-model="password" required>
      </div>
      <button type="submit">SignUp</button>
    </form>
  </div>
</template>


<script lang="ts">
import { defineComponent, ref } from 'vue';
import router from "@/router";
import {signUp as authServiceSignUp} from "@/Helpers/Axios";

export default defineComponent({
  name: 'SignupPage',
  setup() {
    const firstName = ref('');
    const lastName = ref('');
    const phoneNumber = ref('');
    const email = ref('');
    const userName = ref('');
    const password = ref('');

    const signUp = async () => {

      await authServiceSignUp(firstName.value,lastName.value,
                              phoneNumber.value, userName.value,
                              email.value, password.value);
      console.log(userName.value);
      router.push('/Login');
    };

    return { firstName, lastName, phoneNumber, userName, email, password, signUp };
  },
});
</script>
