<template>
  <div class="profile-page">
    <NavBar :name=username />

    <p>{{ username }}</p>
    <p>{{ profilePic }}</p>
    <p>{{ coverPic }}</p>
    <p>{{ bio }}</p>
  </div>
</template>

<script type="module">
import { defineComponent, ref, onMounted } from 'vue';
import { foundUser, foundProfile } from "@/Helpers/Axios";
import NavBar from "@/components/NavBar.vue";

export default defineComponent({
  name: 'ProfilePage',
  components: {NavBar},
  setup(){
    const username = ref('');
    const profilePic = ref('');
    const coverPic = ref('');
    const bio = ref('');

    if(localStorage.getItem(('SearchToken')) == null)
      var token = localStorage.getItem('MyToken');
    else
      var token = localStorage.getItem('SearchToken');

    onMounted(async () =>{
      try{
        const user = await foundUser(token);
        const profile = await foundProfile(user.username);

        username.value = user.username;
        profilePic.value = profile.profilePic;
        coverPic.value = profile.coverPic;
        bio.value = profile.bio;

        console.log('Mounted',username.value);
      }catch (error){
        console.error("Error fetching:", error);
      }
    });
    return {username, profilePic, coverPic, bio};
  }
});

</script>





<style scoped>

</style>