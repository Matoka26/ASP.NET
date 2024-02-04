<template>
  <div class="profile-page">
    <NavBar :name=username />
    <div class="userInfo">
      <p>{{ username }}</p>
      <p>{{ profilePic }}</p>
      <p>{{ coverPic }}</p>
      <p>{{ bio }}</p>
    </div>

    <div class="posts">
      <ul>
        <li v-for="item in items" :key="item.id">
          <Post :username="username" :description="item.description" :picture="item.picture" />
        </li>
      </ul>
    </div>

  </div>
</template>

<script type="module">
import { defineComponent, ref, onMounted } from 'vue';
import { foundUser, foundProfile, getPostsOfUser} from "@/Helpers/Axios";
import NavBar from "@/components/NavBar.vue";
import Post from "@/components/Post.vue";

export default defineComponent({
  name: 'ProfilePage',
  components: {Post, NavBar},
  setup(){
    const username = ref('');
    const profilePic = ref('');
    const coverPic = ref('');
    const bio = ref('');
    const items = ref([]);

    let token = localStorage.getItem('MyToken');


    onMounted(async () =>{
      try{
        const user = await foundUser(token);
        const profile = await foundProfile(user.username);

        username.value = user.username;
        profilePic.value = profile.profilePic;
        coverPic.value = profile.coverPic;
        bio.value = profile.bio;

        items.value = await getPostsOfUser(user.username);
        console.log('Mounted',username.value);
      }catch (error){
        console.error("Error fetching:", error);
      }
    });
    return {username, profilePic, coverPic, bio, items};
  }
});

</script>



<style scoped>
.userInfo{
  background-color: #282828;
  margin: 10px;
  border: 1px solid black;
  padding: 10px 20px;
}
</style>