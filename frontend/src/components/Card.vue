<template>
  <div>
    <v-card class="mx-auto">
      <v-card-text>
        <v-row class="ma-0">
          <div class="image">
            <v-img
              max-height="120"
              max-width="170"
              src="https://picsum.photos/id/11/500/300"
            ></v-img>
          </div>
          <p class="text-h4 text--primary ml-10">{{ title }}</p>
        </v-row>
        <div>
          <div class="parameters mt-4">
            <v-row class="ma-0">
              <span class="parameter-title">Стадия готовности: </span>
              <span class="ml-2">{{ completeStage }}</span>
            </v-row>
            <v-row class="ma-0">
              <span class="parameter-title"
                >Кейсы использования продукта:
              </span>
              <span class="ml-2">{{ useCases }}</span>
            </v-row>
            <v-row class="ma-0">
              <span class="parameter-title"
                >Требуется ли сертификация продукта:
              </span>
              <span class="ml-2">{{ certificationNeed }}</span>
            </v-row>
            <v-row class="ma-0">
              <span class="parameter-title"
                >Требуется ли сертификация продукта:
              </span>
              <span class="ml-2">{{ certificationNeed }}</span>
            </v-row>
            <v-row class="ma-0">
              <span class="parameter-title"
                >Требуется ли сертификация продукта:
              </span>
              <span class="ml-2">{{ certificationNeed }}</span>
            </v-row>
            <v-row class="ma-0">
              <span class="parameter-title"
                >Требуется ли сертификация продукта:
              </span>
              <span class="ml-2">{{ certificationNeed }}</span>
            </v-row>
          </div>
        </div>
      </v-card-text>
      <v-card-actions>
        <v-btn text color="deep-purple accent-4"> Learn More </v-btn>
      </v-card-actions>
    </v-card>
  </div>
</template>

<script>
import Filters from "./Filters.vue";
export default {
  props: [
    "title",
    "completeStage",
    "useCases",
    "certificationNeed",
    "pilotProjectExists",
    "",
  ],
  components: { Filters },
  data: () => ({}),
  methods: {
    log() {
      console.log("log");
    },
  },
};
</script>
<style scoped>
.parameter-title {
  color: black !important;
  font-weight: 600;
}
</style>