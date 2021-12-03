<template>
  <div>
    <div id="search-input">
      <v-text-field
        label="Поиск"
        outlined
        v-model="text"
        hide-details
        prepend-inner-icon="mdi-magnify"
      >
        <div slot="append">
          <v-btn :icon="true" id="filter-btn" @click="text = ''">
            <v-icon> mdi-close </v-icon>
          </v-btn>
          <v-btn :icon="true" id="filter-btn" @click="menuIsOpened = true">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="24"
              height="24"
              viewBox="0 0 24 24"
            >
              <path
                fill="currentColor"
                fill-rule="evenodd"
                d="M6.1 17.25a3 3 0 0 1 5.8 0h8.85a.75.75 0 1 1 0 1.5h-8.84a3 3 0 0 1-5.82 0H3.25a.75.75 0 1 1 0-1.5h2.84zm6-6a3 3 0 0 1 5.8 0h2.85a.75.75 0 1 1 0 1.5h-2.84a3 3 0 0 1-5.82 0H3.25a.75.75 0 1 1 0-1.5h8.84zm-6-6a3 3 0 0 1 5.8 0h8.85a.75.75 0 1 1 0 1.5h-8.84a3 3 0 0 1-5.82 0H3.25a.75.75 0 0 1 0-1.5h2.84zM9 7.5a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zm6 6a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zm-6 6a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3z"
              ></path>
            </svg>
          </v-btn>
        </div>
      </v-text-field>
    </div>
    <v-menu
      offset-y
      activator="#search-input"
      v-model="menuIsOpened"
      :open-on-click="false"
      :close-on-content-click="false"
    >
      <v-sheet class="pa-4"> </v-sheet>
      <Filters> </Filters>
    </v-menu>
  </div>
</template>

<script>
import Filters from "./Filters.vue";
export default {
  components: { Filters },
  data: () => ({
    text: "",
    menuIsOpened: false,
  }),
  methods: {
    log() {
      console.log("log");
    },
  },
  watch: {
    text() {
      console.log("text changed");
    },
  },
};
</script>
<style scoped>
::v-deep .v-text-field--enclosed .v-input__append-inner {
  margin-top: 10px !important;
}
</style>