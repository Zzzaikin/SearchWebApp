<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <v-tabs v-model="tab" align-with-title>
        <v-tabs-slider></v-tabs-slider>

        <v-tab
          v-for="(item, i) in tabs"
          :key="item"
          @click="i == 0 ? goTo('/') : goTo('/request')"
        >
          {{ item }}
        </v-tab>
      </v-tabs>
    </v-app-bar>

    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script>
export default {
  name: "App",

  data: () => ({
    tabs: ["Поиск", "Оставить заявку"],
    tab: 0,
  }),
  /*   watch: {
    tab() {
      if (this.tab === 0) {
        this.$router.push("/");
      } else if (this.tab === 1) {
        this.$router.push("/request");
      }
    },
  }, */
  methods: {
    goTo(path) {
      this.$router.push(path);
    },
  },
};
</script>
<style >
.parameter-title {
  color: black !important;
  font-weight: 600;
}
.parameter-wrapper {
  display: inline-flex;
}
p {
  text-align: justify;
}
</style>
