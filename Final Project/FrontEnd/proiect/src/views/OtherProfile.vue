<template>
  <div class="profile-page">
    <NavBar :name=username @search="handleSearch" />
    <div class="div1">
      <UserInfo :username="username" :profilePic="profilePic"
                :coverPic="coverPic" :bio="bio"/>
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
import UserInfo from "@/components/UserInfo.vue";

export default defineComponent({
  name: 'ProfilePage',
  components: {Post, NavBar,UserInfo},
  setup(){
    const username = ref('');
    const profilePic = ref('');
    const coverPic = ref('');
    const bio = ref('');
    const items = ref([]);

    let token = localStorage.getItem('SearchedToken');


    onMounted(async () =>{
      try{
        const profile = await foundProfile(token);

        username.value = token
        profilePic.value = profile.profilePic;
        coverPic.value = profile.coverPic;
        bio.value = profile.bio;

        items.value = await getPostsOfUser(token);
        console.log('Mounted',username.value);
      }catch (error){
        console.error("Error fetching:", error);
      }
    });
    return {username, profilePic, coverPic, bio, items};
  },
  methods: {
    handleSearch(searchQuery) {
      console.log("Searched:", searchQuery)
      localStorage.setItem('SearchedToken', searchQuery);
      location.reload();
      this.$router.push('/OtherProfile');
    }
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

.div1 {
  padding-top: 80px;
}
</style>